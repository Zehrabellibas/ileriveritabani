# ileriveritabani
Blazor + Leaflet 


Projede Cargo’ların güncel konumlarının takibi yapılmaktadır. Ayrıyeten kargoların özellikleri de konumları ile birlikte veritabanında tutulmaktadır. 
Projeyi uygulamaya koymak için en başta Visual Studio’da yeni bir proje oluşturdum.

BlazorLeaflet.Samples’teki Data klasörüne kargo varlığını Cargo.cs ismi ile class olarak ekledim. Burada veritabanındaki kargo tablosunun column’larının C# kodu 
ile yazılmış hali var. 

Sonra CargoDbContext.cs sınıfını oluşturdum.

Eklediğim kod bloğu aşağıdaki gibidir:
services.AddDbContext<CargoDbContext>( options =>
{ 
options.UseSqlite("Data Source = Cargos.db");
});
  
CargoServices.cs sınıfını da BlazorLeaflet.Samples’teki Data klasörüne ekledim. Bu sınıf, temel CRUD işlemlerini sağlayan hizmet sınıfıdır. Kargo ekleme, 
güncelleme, silme ve listeleme işlemleri bulunmaktadır. 

Blazor.Leaflet.Samples’teki Pages klasörüne CRUD için kullanıcı arayüzü kodunuve mantığını ekledim. Bu dosyanın adını CargoCrud.razor olarak belirledim.
Bu sayfada kargo ekleme, silme, güncelleme, listeleme işlemleri ve bunların yanında kargoların konumlarını görüntüleme işlemleri yapılabilir.

Blazor.Leaflet.Samples’teki Pages klasörüne eklediğimiz CargoTracking.razor ise kargonun map’ten takibini yapmamızı sağlıyor.
  
Index.razor ana sayfamızdır. Projeyi çalıştırdığımızda direkt bu sayfaya yönlendiriliriz. Burada veritabanımızda tutulan kargoların özelliklerini görebiliriz.
Böylece herhangi bir işlem yapmayacağımız zaman sadece tüm kargoları listelemek için Index.razor sayfasına gitmemiz gerekir.

Shapes.razor sayfasında ise bir harita bulunuyor. Merkezi nokta olarak Türkiye’yi gösteren bu haritada Marker’ı istediğimiz gibi hareket ettirerek bulunduğu 
konumun Latitude ve Longitude değelerini öğrenebiliriz.
