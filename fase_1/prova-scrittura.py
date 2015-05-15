def save_tweets(tweet,path):
    file=open(path, 'a')
    file.write(tweet)
    file.close()


if __name__ == '__main__':
    
    save_tweets("\nsradavagnegnewe","tweetami.txt")
        
    print('OK!')