Algorithm al = new Algorithm();
string msg = "";
msg += al.TemplateMethod(new A());
msg += Environment.NewLine + al.TemplateMethod(new B());

Console.WriteLine(msg);