import requests
import base64
#import psycopg2


def get_token(client_id, client_secret):
    credentials = '{}:{}'.format(client_id, client_secret)
    credentials_b64 = base64.b64encode(credentials.encode())
    resp = requests.post(
        'https://api.twitter.com/oauth2/token',
        headers={
            'Authorization': 'Basic {}'.format(credentials_b64.decode())
        },
        data={'grant_type': 'client_credentials'}
    )
    if resp.status_code == 200:
        data = resp.json()
        return data['access_token']
    else:
        raise ValueError(
            'error in request, code={} body={}'.format(
                resp.status_code, resp.text
            )
        )


def search_tweets(what, token):
    '''
    Returns:
      a list of tweets (dictionaries)
    '''
    url = 'https://api.twitter.com/1.1/search/tweets.json'
    resp = requests.get(
        url,
        headers={'Authorization': 'Bearer {}'.format(token)},
        params={'q': what }
    )
    resp.raise_for_status()
    data = resp.json()
    return data['statuses']


def save_tweets(tweet,user,pathT, pathU):
    file=open(pathT, 'a')
    id_user=str(user['id_str'])
    date=str(tweet['created_at'])
    text=str(tweet['text'])
    text=text.replace('\n', ' ')
    file.write(id_user+",")
    file.write(date+",")
    file.write(text+"\n")
    file.close()
    file=open(pathU, 'a')
    location=str(user['location'])
    followers_count=str(user['followers_count'])
    file.write(location+",")
    file.write(followers_count+"\n")
    file.close()


if __name__ == '__main__':
    import os
    import sys
    print('getting token...')
    token = get_token(
        os.environ['TWITTER_APP_ID'],
        os.environ['TWITTER_APP_SECRET']
    )
    print('getting tweets...')
    tweets = search_tweets(sys.argv[1], token)
 

    for tweet in tweets:
        user=tweet['user']
        path_tweet="C:\\Users\\Marika\\Desktop\\ProgettoITSTwitter\\fase_1\\tweet.csv"
        path_users="C:\\Users\\Marika\\Desktop\\ProgettoITSTwitter\\fase_1\\user.csv"
        save_tweets(tweet,user,path_tweet, path_users)
    print('OK!')
