using static System.Console;

interface IButton
{
	void Render();
	void OnClick();
}

class WindowsButton : IButton
{
	public void OnClick() 
		=> WriteLine("Windows Button Click...");
	public void Render() 
		=> WriteLine("Windows Button Render...");
}

class HTMLButton : IButton
{
	public void OnClick()
		=> WriteLine("HTML Button Click...");
	public void Render()
		=> WriteLine("HTML Button Render...");
}

abstract class Dialog
{
	public void Render()
	{
		IButton button = CreateButton();
		button.OnClick();
		button.Render();
	}

	public abstract IButton CreateButton();
}

class WindowsDialog : Dialog
{
	public override IButton CreateButton()
		=> new WindowsButton();
}

class WebDialog : Dialog
{
	public override IButton CreateButton()
		=> new HTMLButton();
}

class Client
{
	public void Run()
	{
		Dialog dialog = new WindowsDialog();
		dialog.Render();

		dialog = new WebDialog();
		dialog.Render();
	}
}

class HW_1_2
{
	static void Main()
	{
		Client client = new Client();
		client.Run();
	}
}