# 🚀 API Load Testing with NBomber + RestSharp

Welcome! This is a fun and practical project to simulate real-world API traffic using [NBomber](https://nbomber.com/) and [RestSharp](https://restsharp.dev/), built entirely in .NET 💪

> 🔎 No YAMLs. No scripting. Just clean C# code!

---

## 📦 What's Included?

### ✅ 1. GET API Load Test
- Endpoint: `/users`  
- Load: 100+ requests/sec  
- Goal: Simulate heavy parallel reads (e.g., dashboard/API listing)

---

### 📁 2. File Upload Stress Test
- Endpoint: `https://echo.free.beeceptor.com/upload`  
- Uploads `.jpg` or `.pdf` files via `multipart/form-data`  
- Goal: Measure how file size affects response time & error rate

---

### 📈 3. Spike Load Simulation
- Load ramp-up: from 50 to 1000 RPS in 30 seconds  
- Goal: Test how server behaves during sudden traffic spikes  
- Bonus: Watch p50/p95 response times under stress!

---

## 📊 Why NBomber?

- ✅ .NET native & developer-friendly
- ✅ No virtual users (like JMeter/K6) — it uses **RPS** directly
- ✅ Built-in HTML reports (p50, p95, error %, throughput)
- ✅ Easy to chain auth flows, simulate edge cases

---

## 🔧 Tech Stack

- [.NET 8](https://dotnet.microsoft.com/)  
- [NBomber](https://nbomber.com/)  
- [RestSharp](https://restsharp.dev/)  
- [Beeceptor](https://beeceptor.com/) – for testing file uploads  

---

## 🛠 How to Run

1. **Clone this repo**
   ```bash
   git clone https://github.com/JohilAngelo22/api-load-testing-restsharp.git
   cd api-load-testing-restsharp
Run with .NET CLI

dotnet run -project api-load-testing-restsharp

Check reports

Reports will be saved in the /reports folder

Formats: .html, .txt, .csv



💡 Ideas to Extend
Add JWT auth flow (login + protected API access)

Simulate slow APIs (2–5s delay) & assert performance thresholds

Try different file sizes (100KB – 5MB)

Chain multiple steps in one scenario


👨‍💻 Author
Made with ❤️ by Johil Angelo

Let's connect on [LinkedIn](https://www.linkedin.com/in/johil-angelo-aa66b91b5/)




Would you like a markdown badge section or GitHub Actions CI badge too?
