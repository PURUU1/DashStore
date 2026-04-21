# 🛒 DashStore

DashStore is a modern, full-stack e-commerce web application built to provide a seamless online shopping experience. Developed using **ASP.NET Core MVC**, this platform features dynamic product catalogs, secure shopping cart management, and automated email confirmations.

## ✨ Features

* **Dynamic Product Catalog:** Browse products seamlessly categorized by type (Smartphones, Laptops, Audio, Gaming, etc.) with real-time search filtering.
* **Modern UI/UX:** Fully responsive, mobile-first design utilizing **Bootstrap 5**. Includes advanced UI components like CSS scroll-snapping carousels and asynchronous skeleton loading states.
* **Session-Based Cart Management:** Secure and reliable shopping cart logic utilizing ASP.NET Core Session state to maintain items during the checkout flow.
* **Automated Email Notifications:** Integrated **MailKit (SMTP)** to automatically dispatch professional, HTML-formatted welcome emails and order confirmation receipts to users.
* **Asynchronous Processing:** Utilizes AJAX and jQuery for smooth, page-refresh-free interactions, such as adding items to the cart and real-time product searching.

## 🛠️ Tech Stack

**Frontend:**
* HTML5, CSS3, JavaScript (ES6+)
* Bootstrap 5 (Responsive Grid & Utility Classes)
* jQuery & AJAX (Asynchronous operations)

**Backend:**
* C# & .NET Core 
* ASP.NET Core MVC Architecture
* ASP.NET Core Identity (Authentication & Authorization)
* MailKit (SMTP Email Service)

**Database:**
* SQL Server
* Entity Framework Core (Code-First Approach & Migrations)

## 🚀 Getting Started

Follow these instructions to set up the project locally on your machine.

### Prerequisites
* [.NET 8.0 SDK](https://dotnet.microsoft.com/download) (or your specific version)
* [Visual Studio 2022](https://visualstudio.microsoft.com/) or VS Code
* SQL Server Express / LocalDB

### Installation Steps

1. **Clone the repository:**
   ```bash
   git clone [https://github.com/yourusername/DashStore.git](https://github.com/yourusername/DashStore.git)
   cd DashStore
