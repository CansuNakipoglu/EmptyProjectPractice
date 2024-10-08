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
Controller - Action - Model -  View - Razor - RazorView - wwwroot kavramlar�n�n ve builder.Build() - app.Run() metotlar�n�n ne i�e yarad�klar�n�,
hangi ama�la kullan�ld�klar�n� yorum sat�r� olarak a��klay�n�z.

Cevap:

Controller: Kullan�c� ile uygulama aras�nda ki ileti�imi sa�lar
Action: Controller i�erisinde tan�mlanan, kullan�c� isteklerini kar��layan metotlard�r
Model: Controller ile view aras�nda veri ileti�iminin sa�lanmas�na olanak tan�r.
View: Kullan�c� aray�z�, kullan�cn�n�n ekranda g�rd��� t�m bile�enler bu katmanda olur.
Razor: Dinamik web sayfalar� yapmam�za olanak sa�layan dil
RazorView: Razor dili kullanarak olu�turdu�umuz dinamik sayfan�n b�t�n�
wwwroot: app.UseStaticFiles() metodu ile default olarak kabul edilen statik klas�r�m�z�n isimi. �stenilirse e�er bu metot �zelle�tirilerek farkl� bir isimde ki klas�r�de statik olarak tan�mlayabiliriz.
builder.Build(): builder'da yapt���m�z t�m konfig�rasyonlar� i�leyip bize bir WebApplication nesnesi d�nd�r�r.
app.Run(): webapplication'�m�z�n son ad�m� diyebiliriz. middlewarelar�m�z�n hepsi �al��t�ktan sonra webapplication d�ng�s� tamamlan�r.

 */