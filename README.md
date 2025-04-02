# AdonetCustomer - ADO.NET ile Müşteri Yönetim Uygulaması ✨

Bu proje, .NET Framework üzerinde C# ve Windows Forms kullanılarak geliştirilmiş basit bir Müşteri ve Şehir Yönetim uygulamasıdır. Veritabanı işlemleri için temel ADO.NET (`System.Data.SqlClient`) kütüphanesi kullanılmıştır.

## 🚀 Genel Bakış

Uygulama, kullanıcıların şehir bilgilerini ve bu şehirlere bağlı müşteri bilgilerini yönetmesine olanak tanır. Temel CRUD (Create, Read, Update, Delete) işlemleri ve basit istatistiksel verilerin görüntülenmesi gibi özellikler sunar.

## 🛠️ Özellikler

*   **Ana Form (`FrmMap`):**
    *   Diğer formlara (Şehir, Müşteri, İstatistik) erişim sağlar.
    *   Uygulamadan çıkış yapma imkanı sunar.
*   **Şehir Yönetimi (`FrmCity`):**
    *   Yeni şehir ekleme.
    *   Mevcut şehirleri listeleme (`DataGridView` üzerinde).
    *   Şehir bilgilerini güncelleme.
    *   Şehir silme.
    *   Şehir adına göre arama yapma.
*   **Müşteri Yönetimi (`FrmCustomer`):**
    *   Yeni müşteri ekleme (Şehir seçimi `ComboBox` ile yapılır).
    *   Mevcut müşterileri listeleme (`DataGridView` üzerinde, şehir adıyla birlikte).
    *   Müşteri bilgilerini güncelleme.
    *   Müşteri silme.
    *   Müşteri adına göre arama yapma.
    *   Müşteri durumunu (Aktif/Pasif) `RadioButton` ile belirleme.
    *   Veritabanındaki saklı yordamı (`CustomerListWithCity`) çalıştırma.
*   **İstatistikler (`FrmStatistics`):**
    *   Toplam şehir sayısını gösterme.
    *   Toplam müşteri sayısını gösterme.
    *   Müşterilerin toplam bakiyesini gösterme.

## ⚙️ Kullanılan Teknolojiler

*   **Programlama Dili:** C#
*   **Framework:** .NET Framework 4.7.2
*   **Arayüz:** Windows Forms (WinForms)
*   **Veri Erişimi:** ADO.NET (`System.Data.SqlClient`)
*   **Veritabanı:** Microsoft SQL Server

## 💾 Veritabanı Kurulumu

Uygulamanın çalışması için bir SQL Server veritabanına ihtiyaç vardır.

1.  **Veritabanı Oluşturma:** SQL Server'da `DbCustomer` adında yeni bir veritabanı oluşturun.
2.  **Tabloları ve Saklı Yordamı Oluşturma:** Aşağıdaki SQL scriptlerini `DbCustomer` veritabanı üzerinde çalıştırın:

    ```sql
    -- TblCity Tablosu
    CREATE TABLE TblCity (
        CityId INT PRIMARY KEY IDENTITY(1,1),
        CityName VARCHAR(50),
        CityCountry VARCHAR(50)
    );
    GO

    -- TblCustomer Tablosu
    CREATE TABLE TblCustomer (
        CustomerId INT PRIMARY KEY IDENTITY(1,1),
        CustomerName VARCHAR(50),
        CustomerSurname VARCHAR(50),
        CustomerCity INT FOREIGN KEY REFERENCES TblCity(CityId),
        CustomerBalance DECIMAL(18, 2),
        CustomerStatus BIT -- 1: Aktif, 0: Pasif
    );
    GO

    -- CustomerListWithCity Saklı Yordamı (Stored Procedure)
    -- Bu prosedür, müşteri listesini şehir adıyla birlikte getirir.
    CREATE PROCEDURE CustomerListWithCity
    AS
    BEGIN
        SELECT
            c.CustomerId,
            c.CustomerName,
            c.CustomerSurname,
            c.CustomerBalance,
            c.CustomerStatus,
            ct.CityName
        FROM
            TblCustomer c
        INNER JOIN
            TblCity ct ON c.CustomerCity = ct.CityId;
    END;
    GO
    ```

3.  **Bağlantı Dizesi (Connection String):** Projedeki `FrmCity.cs`, `FrmCustomer.cs` ve `FrmStatistics.cs` dosyalarında bulunan `SqlConnection` tanımlamalarındaki bağlantı dizelerini kendi SQL Server yapılandırmanıza göre düzenleyin. Özellikle `Server=UMUT\\SQLEXPRESS` kısmını kendi sunucu adınızla değiştirmeniz gerekecektir. Örnek:

    ```csharp
    // Örnek (Her .cs dosyasında ilgili satırı bulun ve güncelleyin):
    SqlConnection sqlConnection = new SqlConnection("Server=YOUR_SERVER_NAME;initial catalog=DbCustomer;integrated security=true");
    ```

## 🏃 Nasıl Çalıştırılır?

1.  Projeyi bilgisayarınıza klonlayın:
    ```bash
    git clone https://github.com/kullanici-adiniz/AdonetCustomer.git
    ```
2.  Yukarıdaki "Veritabanı Kurulumu" adımlarını takip ederek veritabanını hazırlayın.
3.  Proje içindeki bağlantı dizelerini güncelleyin.
4.  `AdonetCustomer.sln` dosyasını Visual Studio (2019 veya üzeri önerilir) ile açın.
5.  Projeyi derleyin (Build -> Build Solution).
6.  Uygulamayı başlatın (Debug -> Start Debugging veya F5). Ana form olarak `FrmMap` açılacaktır.
