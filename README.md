# ToDoList

Çalıştırmak için ;

1-TaskList.Web dosyasına giriniz ardından "ConnectionStrings" alanınına kendi sunucu bilgilerinizi ve oluşturmak istediğiniz tablo adını giriniz.
2-Başlangıç projesini TaskList.Web seçerek çalıştırınız.
3-Veri tabanında kullanıcı ve şifre oluşturduktan sonra giriş yapabilirsiniz.


Veri tabanı hatası almanız durumunda;

$ dotnet ef migrations add TaskItems --startup-project ./ --project ../TaskList.DAL/

ardından 

$ dotnet ef database update --startup-project ./ --project ../TaskList.DAL/

komutlarını çalıştırıp tekrar deneyebilirsiniz.

