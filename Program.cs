var builder = WebApplication.CreateBuilder(args); // buildimizi konfigure etmemiz için gerekli olan Webapplicationbuilder nesnesini döndüren metot

builder.Services.AddControllersWithViews(); // Controller ve viewleri ekleyen metot.

var app = builder.Build(); // Konfigure ettiðimiz webapplicationbuilder'ý build edip webapplication nesnesi döndüren metot

app.UseStaticFiles(); // Statik dosya tanýmlamamýzý saðlayan metot, default olarak wwroot klasorünü alýyor, istenilirse deðiþtirme þansý var.

app.UseRouting(); // Uygulamamýzýn routingini configure ettiðimiz metot default olarak Controller/action'u baz alýyor

app.MapControllerRoute(name: "default",pattern: "{controller=Home}/{action=Index}/{id?}"); // uygulamanýn baþladýðýnda ki default sayfasýný ayarlamamýzý saðlayan metot

app.Run(); // Tüm middlewarelarýmýz tamamlandýktan sonra uygulamamýzý run eden metot.

/* 

Soru:
Controller - Action - Model -  View - Razor - RazorView - wwwroot kavramlarýnýn ve builder.Build() - app.Run() metotlarýnýn ne iþe yaradýklarýný,
hangi amaçla kullanýldýklarýný yorum satýrý olarak açýklayýnýz.

Cevap:

Controller: Kullanýcý ile uygulama arasýnda ki iletiþimi saðlar
Action: Controller içerisinde tanýmlanan, kullanýcý isteklerini karþýlayan metotlardýr
Model: Controller ile view arasýnda veri iletiþiminin saðlanmasýna olanak tanýr.
View: Kullanýcý arayüzü, kullanýcnýnýn ekranda gördüðü tüm bileþenler bu katmanda olur.
Razor: Dinamik web sayfalarý yapmamýza olanak saðlayan dil
RazorView: Razor dili kullanarak oluþturduðumuz dinamik sayfanýn bütünü
wwwroot: app.UseStaticFiles() metodu ile default olarak kabul edilen statik klasörümüzün isimi. Ýstenilirse eðer bu metot özelleþtirilerek farklý bir isimde ki klasörüde statik olarak tanýmlayabiliriz.
builder.Build(): builder'da yaptýðýmýz tüm konfigürasyonlarý iþleyip bize bir WebApplication nesnesi döndürür.
app.Run(): webapplication'ýmýzýn son adýmý diyebiliriz. middlewarelarýmýzýn hepsi çalýþtýktan sonra webapplication döngüsü tamamlanýr.

 */