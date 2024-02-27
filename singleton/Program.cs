// See https://aka.ms/new-console-template for more information

using singleton;

var sing1 = Singleton.CreateInstance();
sing1.ShowMessage();

var sing2 = Singleton.CreateInstance();
sing2.ModifyMessage("Singleton is doing something else");

sing1.ShowMessage();