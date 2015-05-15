package projectWork.cleaning;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class GestioneCsv {

	/**
	 * importa un file csv e torna una lista di persone
	 * @param percorsoFile
	 * @return null in caso di errore
	 */
	public List<Tweet> importa(String percorsoFile) {
		
		try(BufferedReader lettore = new BufferedReader(new FileReader(percorsoFile))){
			
			List<Tweet> tweet = new ArrayList<Tweet>();
			
			String line;
			while((line = lettore.readLine()) != null) {
				
				String[] data = line.split(",");
				
				String tw="";
				for (int i=2; i<data.length; i++){
					if(i!=data.length-1)
						tw+=data[i]+",";
					else
						tw+=data[i];
				}
				
				Tweet t = new Tweet();
				t.setId(data[0]);
				t.setData(data[1]);
				t.setTesto(tw);
				
				tweet.add(t);
			}
			return tweet;
		} catch (Exception e) {
			System.out.println(e.getMessage());
			return null;
		}
	}
	
	public void scrivi(List<Tweet> tweets){
		try (BufferedWriter out = new BufferedWriter(new FileWriter("new_tweet.txt", true))) {	
			for(Tweet t:tweets){
				String s=t.print();
				out.write(s);
				out.newLine();
			}
			} catch (IOException e) {
				e.printStackTrace();
			}
	}
}