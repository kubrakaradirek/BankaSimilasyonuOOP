using BABankOOP;
using BABankOOP.Insanlar.Personeller;
using System.ComponentModel;

//Tekrar bakılacak, 

GuvenlikGorevlisi guvenlikGorevlisi = new GuvenlikGorevlisi("Mahmut");
Console.WriteLine(guvenlikGorevlisi.Gorev);
Console.WriteLine("------");

AttributeCollection attributes = TypeDescriptor.GetProperties(guvenlikGorevlisi)["Gorev"].Attributes;

DescriptionAttribute myAttribute = (DescriptionAttribute)attributes[typeof(DescriptionAttribute)];

Console.WriteLine(myAttribute.Description);