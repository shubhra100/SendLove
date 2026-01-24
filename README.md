💖 SendLove – Online Gift Delivery Web Application
SendLove is a full-stack ASP.NET Core MVC web application designed for online gift selection and delivery based on occasions like Birthday, Valentine’s Day, Mother’s Day, Friendship Day, etc.
The project demonstrates frontend UI design, backend logic, database integration, and MVC architecture.

Features :

🎁 Browse gifts by occasion (Birthday, Sorry, Thank You, etc.)

👩‍❤️‍👨 Filter products by recipient (For Her / For Him / Any)

🛒 Add products to cart

💳 Checkout page with order details

🗄️ Products stored and fetched from SQL Server

🔗 Entity Framework Core integration

🎨 Clean and aesthetic UI inspired by modern ecommerce designs


Tech Stack :
Frontend
HTML5
CSS3
JavaScript
Razor Views (ASP.NET MVC)
Backend
ASP.NET Core MVC (.NET 8)
C#
Entity Framework Core
Database
Microsoft SQL Server (SQLExpress)
Code-First / Database-First compatible structure


Project Structure :
SendLove
│
├── Controllers
│   ├── HomeController.cs
│   ├── ProductController.cs
│   └── CheckoutController.cs
│
├── Models
│   ├── ProductEntity.cs
│   └── CartItem.cs
│
├── Data
│   └── SendLoveContext.cs
│
├── Views
│   ├── Home
│   ├── Product
│   ├── Checkout
│   └── Shared
│
├── wwwroot
│   ├── css
│   ├── images
│   └── js
│
├── appsettings.json
├── Program.cs
└── README.md


🗄️ Database Schema (Products Table) :
Column	Type
Id	int (Identity, PK)
Name	nvarchar(200)
Occasion	nvarchar(100)
Section	nvarchar(100)
Gender	nvarchar(50)
Price	decimal(10,2)
ImageUrl	nvarchar(300)


⚙️ Setup Instructions :
1️⃣ Clone the Repository
git clone https://github.com/your-username/SendLove.git
2️⃣ Open in Visual Studio
Open SendLove.sln
Make sure .NET 8 SDK is installed
3️⃣ Configure Database
Update appsettings.json:
"ConnectionStrings": {
  "SendLoveDB": "Server=localhost\\SQLEXPRESS;Database=SendLoveDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
4️⃣ Run SQL Server
Create database SendLoveDB
Create Products table
Insert product data
5️⃣ Run the Application
Press F5 in Visual Studio
Open browser at:
https://localhost:7204


📸 Screenshots :
Home Page (Hero Section)
Occasion Selection
Product Listing
Cart & Checkout
(Add screenshots here later)


📌 Learning Outcomes :
ASP.NET Core MVC architecture
Entity Framework Core usage
SQL Server integration
Filtering & querying data
Building real-world ecommerce UI
Debugging backend & database issues  


🔮 Future Enhancements :

👤 User Authentication & Authorization

🧾 Order History

🛠️ Admin Panel (Add/Edit Products)

💳 Payment Gateway Integration

📦 Order Tracking

📱 Mobile Responsive UI



👩‍💻 Author :

Shubhra Divyadarshini
Fresher | Aspiring Full-Stack / .NET Developer
Believes in hard work, consistency, and learning by building 🌱

⭐ Support :

If you like this project, don’t forget to star ⭐ the repository!

