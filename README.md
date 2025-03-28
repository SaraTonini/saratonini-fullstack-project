# saratonini-fullstack-project

# Reflection on InventoryHub Development

## How Copilot Helped
- **Integration:** Copilot suggested efficient approaches for API integration, reducing manual coding time.
- **Debugging:** It provided fixes for common errors like route mismatches and CORS issues.
- **JSON Structuring:** Copilot ensured proper nesting and formatting of JSON responses.
- **Optimization:** It recommended caching strategies and helped refactor repetitive code.

## Challenges and Solutions
- **Challenge:** Handling JSON deserialization errors.
  - **Solution:** Implemented try-catch blocks with Copilot's assistance.
- **Challenge:** Debugging CORS issues.
  - **Solution:** Configured CORS using Copilot-generated middleware configuration.

## Learnings
- Copilot is highly effective for reducing development time and providing suggestions during complex tasks.
- It excels in repetitive tasks but requires careful review to ensure best practices.

---

## Project Description

### Blazor Front-End
The **Blazor Front-End** is built using Blazor WebAssembly technology to provide a seamless and interactive user interface. The front-end focuses on fetching and displaying product data retrieved from the back-end API. Key functionalities include:
- **Product List Page:** Implemented in `FetchProducts.razor`, this page retrieves product data from the `/api/productlist` endpoint and displays details such as product name, price, and category.
- **Caching Strategy:** The front-end uses a static variable to cache product data, reducing redundant API calls and improving performance.
- **Responsive UI:** The user interface adapts smoothly to changes in API responses, with error handling and loading indicators.
- **Integration:** The `HttpClient` service was configured in `Program.cs` to handle API communication efficiently, pointing to the back-end URL.

### Minimal API Back-End
The **Minimal API Back-End** is designed to handle API requests and provide structured JSON responses. Built with .NET Minimal APIs, the back-end includes:
- **API Endpoint:** The `/api/productlist` endpoint returns product details in a structured JSON format, including nested category objects.
- **CORS Configuration:** Configured in `Program.cs` to allow cross-origin requests from the front-end application during development.
- **Performance Optimization:** Product data is cached in memory and reused across API calls, minimizing server load and improving response time.
- **Structured JSON:** The JSON responses include essential fields such as product ID, name, price, stock, and category (with category ID and name).

---

## Technologies Used
- **Front-End:** Blazor WebAssembly (C#)
- **Back-End:** .NET Minimal APIs
- **Development Tools:** Visual Studio Code, Postman, GitHub
- **Testing:** Localhost environment with integrated debugging and validation of API responses.

---
