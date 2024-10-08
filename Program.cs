var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

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