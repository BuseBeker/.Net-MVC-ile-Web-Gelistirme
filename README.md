ASP.NET MVC ile `Entity Framework` kullanarak `SQL Server` veritabanını, 
`çok katmanlı` mimari ile besleyen, kullanıcı arayüzünde `Html-Css-Bootstrap` kullanan temiz kod ve `SOLID` prensiplerini uygulayan ve 
`Codefirst yaklaşımı` kullanarak “Kullanıcı, Admin ve Editör panelli” projenin ilk sürümü geliştirildi. 

Projemde bulunan katmanlar;

- `Business Layer`: Sunum katmanından gelen bilgileri gerekli koşullara göre işleyerek veya denetleyerek veri katmanının sağladığı metotları kullanarak veritabanına gönderen aynı şekilde veritabanından da bilgileri alarak gerekli süreçlerden geçirip presentation katmanına gönderen katman.

-	`Data Access Layer`: Bu katmanda sadece veritabanı işlemleri yapılmaktadır. Bu katmanın görevi veriyi ekleme, silme, güncelleme ve veritabanından çekme işlemidir

-	`Entity Layer`: Domain olarak adlandırılan classlar bu katmanda tanımlanır. Proje boyunca kullanılacak ana classları yani gerçek nesnelerin belirlenildiği katmandır.

-	`UI`: MVC uygulaması, Windows Form uygulaması, Android Mobil Uygulama gibi uygulamaların arayüz katmanıdır. Yani kullanıcıyla etkileşime geçilen işlemler bu katmanda gerçekleştirilir. Bu katmanda kullanıcıdan gelen verileri Business ile Data katmanına yönlendirir.


Ek olarak SOLID prensipleri şunlardır:

- S: Tek Sorumluluk Prensibi (Single Responsibility Principle)
- O: Açık/Kapalı Prensibi (Open/Closed Principle)
- L: Liskov İkame Prensibi (Liskov Substitution Principle)
- I: Arayüz Ayrımı Prensibi (Interface Segregation Principle)
- D: Bağımlılık Tersine Çevirme Prensibi (Dependency Inversion Principle)

`Tek Sorumluluk Prensibi (Single Responsibility Principle)`: Her sınıfın ve modülün sadece tek bir sorumluluğu olmalıdır. Bir sınıfın değiştirilmesi yalnızca bu sorumluluğu etkilemelidir ve diğer sınıfların işleyişini etkilememelidir. 
Örneğin, bir garsonun sadece yemek servisi yapması ve temizliği ile ilgilenmesi, bu prensibe örnek olarak verilebilir. Garsonun sadece bir işlevi olduğu için, diğer garsonların işleyişini veya müşteri hizmetini etkilemeden sadece kendi sorumluluklarını yerine getirmesi gerekmektedir.

`Açık/Kapalı Prensibi (Open/Closed Principle)`: Yazılım bileşenleri, değişikliklere kapalı ama yeni işlevselliğe açık olmalıdır. Yeni gereksinimler ortaya çıktığında, kodu değiştirmeden yeni işlevselliği eklemek mümkün olmalıdır.
Örneğin, bir ev sahibinin, bir odanın fonksiyonunu değiştirmeden farklı bir dekorasyonla yenileyebilmesi bu prensibe örnek olarak verilebilir. Bu prensip, yenilikleri uygulayarak yazılımı geliştirirken, mevcut kodu değiştirmeden yeni işlevselliği eklememize izin verir.

`Liskov İkame Prensibi (Liskov Substitution Principle)`: Alt sınıflar, üst sınıfların yerine geçebilmelidir. Yani, üst sınıfların tüm davranışlarını korumalıdırlar.
Örneğin, bir akülü aracın, bir benzinli aracın yerine geçebilmesi ve aynı şekilde çalışabilmesi, bu prensibe örnek olarak verilebilir. Bu prensip, bir sınıfın alt sınıflarının, üst sınıflarının tüm davranışlarını koruması gerektiğini ifade eder.

`Arayüz Ayrımı Prensibi (Interface Segregation Principle)`: Arayüzler mümkün olduğunca küçük olmalıdır. Arayüzler, yalnızca kullandıkları yöntemleri içermelidirler, kullanılmayan yöntemleri içermemelidirler.
Örneğin, bir müşterinin, yalnızca ihtiyacı olan ürün ve hizmetleri gösteren bir e-ticaret sitesinin, fazladan özelliklerle dolu olmaması, bu prensibe örnek olarak verilebilir. Bu prensip, arayüzlerin kullanılmayan yöntemleri içermemesi ve sadece ihtiyaç duyulan yöntemleri içermesi gerektiğini ifade eder.

`Bağımlılık Tersine Çevirme Prensibi (Dependency Inversion Principle)`: Yüksek seviyeli modüller, düşük seviyeli modüllere bağımlı olmamalıdır. Bunun yerine, her ikisi de soyutlamalara (abstractions) bağımlı olmalıdır.
Örneğin, bir evin temelindeki yapının, evin çatısına bağlı olması yerine her ikisinin de birbirine bağımlı olmadan, her ikisi de soyutlamalara (abstractions) bağlı olması gerektiği, bu prensibe örnek olarak verilebilir. Bu prensip, yazılım bileşenlerinin, birbirlerine bağımlılık içinde olmadan esnek bir şekilde değiştirilebilir ve ölçeklenebilir olması gerektiğini ifade eder.


---

Projenin amacı kullanıcıların başvurularını eklediği ve adminin de bu başvuruları değerlendirip onayladığı ya da reddettiği bir web uygulaması yapmaktır. Teknoloji olarak .Net MVC kullanılacaktır. Database olarak ise MSSQL kullanılacaktır. Kullanıcı ekranında 7 sayfa bulunmakta iken yönetici ekranında da 12 sayfa bulunmaktadır. Avoucher (müdür yerine onaylayan kimse) ekranında da 7 sayfa bulunmaktadır. Toplamda projede 26 sayfa (Register – Login ortak) bulunmaktadır. Aynı zamanda `session`, `authentication` ve `authorization` işlemleri için de gerekli kodlar yazıldı. Projede yer alan sayfalar;


Kullanıcı ekranındaki sayfalar; 

-	Register Sayfası

![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/7802578d-d1f0-4a0a-98c8-bde7b9d8543c)


-	Login Sayfası

![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/50219a6a-723b-4ff1-9059-13ff6461b549)


-	Anasayfa

![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/6a009b48-3552-45ac-815c-d12e30f1d27b)


-	Kullanıcıya Ait Başvuru Listelendiği Sayfa

![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/bcc2e7d1-4bd7-494d-a075-d754a77bff29)


-	Başvuru Ekleme Sayfası

![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/f6794c8a-7414-4f30-8d20-c8244d3b8c9b)

-	Başvuru Düzenleme Sayfası

![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/a62e3d01-b11e-49ff-8d0d-1f41f38ce646)


-	Başvuru Görüntüleme Sayfası

![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/c70d561d-26c4-461d-82ea-bbc9ac584654)



Yönetici ekranındaki sayfalar; 

-	Register Sayfası 
-	Login Sayfası 
-	Anasayfa

![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/1bd92864-a129-48f5-9288-3f1f13f5d6d7)


-	Başvuruların Listelendiği Sayfa

![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/4a59d9db-826b-4465-97c4-e0b78fb16c04)


-	Onay Bekleyen Başvurular Sayfası

![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/827ae531-f881-46d6-8d7f-a898d6e7d251)


-	Başvuru Görüntüleme Sayfası

![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/840709cb-5634-45d1-86b2-919e0aee362b)


-	Başvuru Değerlendirme Sayfası

![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/87ff31ce-f702-4580-a23c-4c77e6797710)


-	Kullanıcıları Görüntüleme Sayfası 
-	Kullanıcıların Bilgisinin Bulunduğu Sayfa

![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/3c88929b-5263-44ab-8347-0ee45782f98d)


-	Kullanıcı ve Rollerinin Bulunduğu Sayfa

![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/8ed8abe6-6014-4a4a-b33f-d241eafc914b)


-	Admin Rol Güncelleme Sayfası

![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/8ab010f9-51d3-46fd-8ec4-f797701493c0)


-	Yeni Rol Ekleme Sayfası


![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/7ae606c1-3a61-4db4-9814-924631b0f241)

  

Avoucher ekranındaki sayfalar; 

-	Register Sayfası 
-	Login Sayfası 
-	Anasayfa 
-	Başvuruların Listelendiği Sayfa
-	Başvuru Görüntüleme Sayfası 
-	Başvuru Değerlendirme Sayfası
-	Onay Bekleyen Başvurular Sayfası

---
Aynı zamanda projeye `Success` ve `Error Temp Data` mesajları da eklenmiştir. İşte bazı örnekleri;

![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/b80856c3-2e3f-4fae-8bda-ccf656659aea)

![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/aa4d6465-557a-4311-97e9-bc72c348b7b5)

![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/ef266512-c37d-4e69-a57a-43385aa2955b)

![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/03a04023-4076-4763-98e7-2f960376ec7a)

![image](https://github.com/BuseBeker/.Net-MVC-ile-Web-Gelistirme/assets/72763515/99459364-a4af-4b28-8eac-0c2066d4cd57)


