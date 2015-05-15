package projectWork.cleaning;
import java.util.List;

public class Main {

	public static void main(String[] args) {
		
		String csvFile = "tweet.csv";
		
		GestioneCsv csv = new GestioneCsv();
		
		List<Tweet> tweets = csv.importa(csvFile);
		
		
		for(Tweet t:tweets)
			System.out.println(t.print());
		
		for(int i=0;i<tweets.size()-1; i++){
			for(int j=tweets.size()-1; j>=0; j--){
				if(tweets.get(j).getTesto().contains("RT "))
					tweets.remove(tweets.get(j));
			}
		}
		System.out.print("\n\n");
		
		for(Tweet t:tweets)
			System.out.println(t.print());

		csv.scrivi(tweets);

	}

}
