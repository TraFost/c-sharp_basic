# Namespace Formatting Best Practices

### 1. Organize Namespaces by Project Structure

The namespace hierarchy should reflect the folder structure of your project. This helps maintain consistency and makes navigation easier.

**Example Project Structure:**

```
ProjectName/
├── Models/
│   ├── User.cs
│   ├── Product.cs
├── Services/
│   ├── UserService.cs
│   ├── ProductService.cs
```

**Example Namespaces:**

```csharp
// In User.cs
namespace ProjectName.Models
{
    public class User
    {
        public string Name { get; set; }
    }
}

// In Product.cs
namespace ProjectName.Models
{
    public class Product
    {
        public string Name { get; set; }
    }
}

// In UserService.cs
namespace ProjectName.Services
{
    public class UserService
    {
        public void PrintUserInfo()
        {
            Console.WriteLine("User service logic here...");
        }
    }
}
```

---

### 2. Use a Root Namespace for Clarity

Always start with a root namespace based on the project or organization name. This prevents name conflicts with third-party libraries or other projects.

**Example:**
For a project named "MyApp", use `MyApp` as the root namespace:

```csharp
namespace MyApp.Models { }
namespace MyApp.Services { }
namespace MyApp.Utils { }
```

---

### 3. Group `using` Directives

Group `using` directives logically:

1. System namespaces first.
2. Third-party namespaces.
3. Project-specific namespaces.

**Example:**

```csharp
using System;
using System.Collections.Generic;

using Newtonsoft.Json; // Third-party library

using MyApp.Models; // Project-specific
using MyApp.Services;
```

---

### 4. Avoid Nested Namespaces Unless Necessary

Keep your namespaces simple and flat. Deeply nested namespaces can make the code harder to navigate.

**Bad Practice:**

```csharp
namespace MyApp.Core.Services.UserManagement.Data
{
    public class UserRepository { }
}
```

**Good Practice:**

```csharp
namespace MyApp.Services
{
    public class UserRepository { }
}
```
