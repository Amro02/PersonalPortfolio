# Personal Portfolio

A modern, responsive personal portfolio website built with ASP.NET Core, Blazor, and Bootstrap. Showcase your projects, skills, and experience with a polished, professional design.

## Features

✨ **Modern & Responsive Design**
- Beautiful gradient hero section with glass-morphism effects
- Fully responsive layout that works on desktop, tablet, and mobile
- Smooth animations and hover effects

🎨 **Professional Sections**
- Hero introduction with call-to-action buttons
- "What I Build" feature cards
- Skills and technology showcase
- Project showcase area
- Contact form with validation
- Contact information panel

⚡ **Built with Modern Tech**
- ASP.NET Core 10
- Server-Side Blazor for interactive components
- Bootstrap 5 for responsive grid and components
- Custom CSS with CSS variables for easy theming
- Font Awesome icons

🔧 **Easy to Customize**
- Simple placeholder text throughout
- Configurable contact information
- Easy-to-update project cards
- Customizable color scheme via CSS variables

## Tech Stack

- **Backend**: ASP.NET Core 10 (MVC + Blazor Server)
- **Frontend**: HTML5, CSS3, JavaScript, Bootstrap 5
- **Components**: Razor Components (Blazor)
- **Icons**: Font Awesome 6
- **Styling**: Custom CSS with CSS variables

## Prerequisites

- .NET 10 SDK or later
- Visual Studio Code or Visual Studio (optional)
- Git (for version control)

## Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/personalportfolio.git
   cd personalportfolio/personalportfolio
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Build the project**
   ```bash
   dotnet build
   ```

## Running Locally

### Development Mode (with hot reload)
```bash
dotnet watch run
```
Then open your browser to:
- `https://localhost:7225` (HTTPS)
- `http://localhost:5144` (HTTP)

### Standard Run
```bash
dotnet run
```

## Customization Guide

### Update Your Information

1. **Hero Section** (`Views/Home/Index.cshtml`)
   - Replace "Hello, I'm Amr Hesham" with your name
   - Update the tagline and description
   - Customize the skills badges

2. **Contact Information** (`Views/Home/Index.cshtml`)
   - Update email address
   - Change phone number
   - Update location
   - Modify availability text

3. **Projects Section**
   - Add your project cards with titles, descriptions, and links
   - Replace placeholder project information

4. **Styling** (`wwwroot/css/portfolio.css`)
   - Modify color scheme by updating CSS variables:
     ```css
     :root {
         --primary-color: #0b3d91;
         --secondary-color: #3f83ff;
         --accent-color: #ff5e74;
     }
     ```

### Contact Form

The contact form (`Components/ContactForm.razor`) is pre-built with:
- Name, Email, Subject, and Message fields
- Real-time validation
- Success/error messages
- Loading state during submission

To integrate with a backend:
1. Add email service to `Program.cs`
2. Update `HandleSubmit()` in `ContactForm.razor` to send emails

## Project Structure

```
personalportfolio/
├── Components/
│   ├── ContactForm.razor        # Contact form component
│   └── ProjectCard.razor        # Project card component
├── Controllers/
│   ├── HomeController.cs        # Main navigation controller
│   └── ContactController.cs     # Contact form handler
├── Models/
│   ├── ContactMessage.cs        # Contact form model
│   ├── Project.cs              # Project model
│   └── ErrorViewModel.cs       # Error model
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml        # Homepage
│   │   ├── Projects.cshtml     # Projects page
│   │   └── Privacy.cshtml      # Privacy page
│   └── Shared/
│       ├── _Layout.cshtml      # Master layout
│       └── _Layout.cshtml.css  # Layout styles
├── wwwroot/
│   ├── css/
│   │   └── portfolio.css       # Custom styles
│   ├── js/
│   │   └── site.js            # Custom scripts
│   └── lib/                   # Third-party libraries
├── _Imports.razor             # Blazor imports
├── Program.cs                 # Application startup
├── personalportfolio.csproj   # Project file
└── README.md                  # This file
```

## Deployment

### Deploy to Azure App Service

1. **Create an Azure App Service**
   - Log in to [Azure Portal](https://portal.azure.com)
   - Create new App Service (.NET 10, Windows)

2. **Publish your app**
   ```bash
   dotnet publish -c Release
   ```

3. **Deploy using Azure CLI**
   ```bash
   az webapp up --name <your-app-name> --resource-group <your-rg>
   ```

4. **Or use Visual Studio**
   - Right-click project → Publish
   - Select Azure App Service
   - Follow the wizard

### Add a Custom Domain

1. In Azure App Service → Custom domains
2. Add your domain name
3. Update DNS records with your domain registrar
4. Enable HTTPS with Azure-managed certificate

### Environment Variables

In `launchSettings.json`, the app runs in Development mode by default:
```json
"ASPNETCORE_ENVIRONMENT": "Development"
```

For production, update to:
```json
"ASPNETCORE_ENVIRONMENT": "Production"
```

## Features to Add

- [ ] Project filtering by technology
- [ ] Blog or articles section
- [ ] Dark mode toggle
- [ ] Multi-language support
- [ ] Email notifications for contact form
- [ ] Analytics integration
- [ ] Social media links
- [ ] PDF resume download

## Contributing

This is a personal portfolio project. To customize it for yourself:
1. Fork the repository
2. Update content and styling
3. Deploy to your hosting platform
4. Share your portfolio!

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Getting Help

- **ASP.NET Core Documentation**: https://learn.microsoft.com/en-us/aspnet/core
- **Blazor Guide**: https://learn.microsoft.com/en-us/aspnet/core/blazor
- **Bootstrap 5 Docs**: https://getbootstrap.com/docs/5.0

## Author

**Amr Hesham**
- Email: [amr.portfolio@example.com](mailto:amr.portfolio@example.com)
- Phone: +20 111 234 5678
- Location: Cairo, Egypt

---

Built with ❤️ using ASP.NET Core and Blazor
