package projectWork.cleaning;

public class Tweet {
	
	private String id;
	private String data;
	private String testo;
	
	public String getId() {
		return id;
	}
	public void setId(String id) {
		this.id = id;
	}
	public String getData() {
		return data;
	}
	public void setData(String data) {
		this.data = data;
	}
	public String getTesto() {
		return testo;
	}
	public void setTesto(String testo) {
		this.testo = testo;
	}

	public String print(){
		return id+","+data+","+testo;
	}

}
