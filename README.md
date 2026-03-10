📊 DatabaseMastery – ASP.NET Core Veritabanı Yönetimi Projesi

Bu proje, Murat Yücedağ tarafından hazırlanan “ASP.NET Core ile MongoDB, PostgreSQL ve MSSQL kullanarak 3 farklı gerçek dünya projesi geliştirme” eğitim serisinin ilk projesi olarak geliştirilmiştir.

DatabaseMastery projesinin temel amacı, ASP.NET Core kullanarak veritabanı işlemlerinin etkin bir şekilde yönetilmesini öğrenmek ve gerçek dünya senaryolarına uygun bir backend mimarisi oluşturmaktır.

Bu proje kapsamında MSSQL veritabanı ile veri yönetimi, Entity Framework Core ile ORM kullanımı ve katmanlı mimari yaklaşımı uygulanmıştır.

🚀 Kullanılan Teknolojiler

Projede aşağıdaki teknolojiler ve geliştirme yaklaşımları kullanılmıştır:

ASP.NET Core

MSSQL Server

Entity Framework Core

LINQ

Katmanlı Mimari (Layered Architecture)

Repository Design Pattern

CRUD (Create, Read, Update, Delete) işlemleri

🎯 Projenin Amacı

Bu proje ile aşağıdaki konularda pratik deneyim kazanılması hedeflenmiştir:

ASP.NET Core ile veritabanı tabanlı uygulama geliştirme

Entity Framework Core kullanarak veri yönetimi

CRUD işlemlerinin uygulanması

Projelerde temiz kod ve sürdürülebilir mimari oluşturma

Gerçek dünya senaryolarına uygun backend geliştirme süreçleri

🏗 Proje Mimarisi

Proje, sürdürülebilir ve ölçeklenebilir bir yapı oluşturmak amacıyla Katmanlı Mimari (Layered Architecture) kullanılarak geliştirilmiştir.

DatabaseMastery
│
├── EntityLayer
│   → Veritabanı varlık modelleri
│
├── DataAccessLayer
│   → Veritabanı işlemleri ve repository yapısı
│
├── BusinessLayer
│   → İş kuralları ve servis katmanı
│
└── PresentationLayer
    → ASP.NET Core MVC kullanıcı arayüzü

Bu mimari yapı sayesinde proje;

modüler

bakımı kolay

geliştirilebilir

bir hale getirilmiştir.

📸 Proje Görselleri

Arayüz e ait görseller
--------------------------
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/faecde80-30a7-4e8a-b38a-91723e64d830" />
<img width="1907" height="1079" alt="image" src="https://github.com/user-attachments/assets/77b08363-ca25-4ba6-881b-baa227dc6eba" />
<img width="1915" height="1079" alt="image" src="https://github.com/user-attachments/assets/151f7200-af73-4560-843f-83b24d5eec9f" />
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/3f10a826-dfef-4c1b-aee5-02c60666a63d" />
<img width="1907" height="1079" alt="image" src="https://github.com/user-attachments/assets/6fb1f509-93a0-4b15-aa00-dc2b2a124e3b" />
<img width="1916" height="1079" alt="image" src="https://github.com/user-attachments/assets/9b601952-7f67-4af4-8ec9-a15159e6459d" />
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/66d84e63-f81a-4531-aaa4-cd717e62ee65" />
<img width="1919" height="1074" alt="image" src="https://github.com/user-attachments/assets/8ee35c6e-4730-482f-8819-9ff378990fe2" />
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/1a1e510f-60d4-4af9-ac02-38f723f94105" />
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/8d3a2137-c8e1-40c0-bd27-cd8d17685a60" />
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/7e71d37a-680d-4a1f-be8e-2124d8063b7b" />

Admin paneline ait görseller
-----------------------------
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/25247aec-0332-46d4-9d4c-8269c4d158b6" />
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/fc992fe4-7857-4be7-b431-fa5fc138d758" />
<img width="1918" height="1079" alt="image" src="https://github.com/user-attachments/assets/e39bf1ac-7b0a-4c11-96a9-e17d715d6be3" />
<img width="1909" height="1079" alt="image" src="https://github.com/user-attachments/assets/257b6081-f506-42e8-bcde-54120713f6ac" />
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/c6972d14-53d5-46f3-b64d-1366828a5852" />
<img width="1919" height="1075" alt="image" src="https://github.com/user-attachments/assets/c203af43-6063-441d-a028-0f0fd1bd3a49" />
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/063f038a-1720-42d9-a45d-3fcaccd95342" />
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/da71259a-598f-4185-bc4f-913b63315a4e" />
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/ccb34049-4613-4ace-864f-3e8cbcd6aed6" />
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/07c9d64d-96d9-4972-a2bd-cf9fd224879d" />
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/f4673d20-436e-4ca7-a5a5-756d92516dd7" />

📚 Eğitim Serisi

Bu proje, 3 farklı veritabanı teknolojisini kapsayan eğitim serisinin ilk aşamasıdır:

1️⃣ASP.NET Core + MongoDB Projesi ✔️
2️⃣ ASP.NET Core + PostgreSQL Projesi (Yakında)
3️⃣ ASP.NET Core + MSSQL Projesi (Yakında)

Bu seri ile farklı veritabanı sistemleri üzerinde uygulama geliştirme yetkinliğimi geliştirmeyi hedefliyorum.

👨‍💻 Geliştirici

Ersin Bulut

🎓 İstanbul Arel Üniversitesi – Bilgisayar Programcılığı
💻 Software Developer

⭐ Projeyi faydalı bulduysanız repo’ya yıldız vermeyi unutmayın.











