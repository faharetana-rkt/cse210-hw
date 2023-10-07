public class Entry
{
	public string _date = DateTime.Now.ToString("dd/MM/yyyy");
	public string _hour = DateTime.Now.ToString("HH:mm:ss");
	public string _prompt;
	public string _response;

	public Entry ()
	{
	}

	public string GetDisplayString(string date, string hour, string prompt, string response)
	{
		return $"{date} {hour} - {prompt} \n{response}";
	}

}