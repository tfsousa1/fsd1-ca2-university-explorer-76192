\# University Explorer Portal



\## Overview



The University Explorer Portal is a Blazor web application developed for the Full Stack Development CA2 assignment.



The application combines external country and university APIs to allow users to explore countries and their universities. It also integrates with the Student Application API to retrieve, create and edit student applications.



\## Features



\### 1. University Explorer



\- Retrieve and display a list of countries.

\- Select a country from a dropdown list.

\- Display country information, including its name, capital, region, population and flag.

\- Retrieve and display universities associated with the selected country.

\- Search universities by name.

\- Select a university to display additional details, including its country, website and domain.



\### 2. Student Applications



\- Retrieve and display student applications from the Student Application API.

\- Display application information, including student name, university, country and course.

\- Provide access to the application editing page.



\### 3. Create Student Application



\- Submit a new student application using the API.

\- Collect student name, email address, country, university name and course name.

\- Validate required fields.

\- Validate email address format.

\- Display validation messages when required information is missing.



\### 4. Edit Student Application



\- Retrieve an existing application using its ID.

\- Display the existing information in an editable form.

\- Submit changes to the API using a PUT request.



\## Technologies Used



\- C#

\- Blazor

\- .NET

\- Razor Components

\- HTML

\- CSS

\- REST APIs

\- JSON

\- HttpClient

\- DataAnnotations



\## API Integration



\### Country and University Data



The University Explorer combines external country and university data sources to display country information and related universities.



\### Student Application API



The application uses the following API endpoint:



`https://edutots.net/api/studentapplication`



The following HTTP operations are implemented:



| HTTP Method | Purpose |

|---|---|

| GET | Retrieve student applications |

| POST | Create a new student application |

| PUT | Update an existing student application |



\## Component Structure



The application uses reusable Razor components to organise its functionality.



| Component | Responsibility |

|---|---|

| `CountryDetails.razor` | Displays selected country information |

| `UniversityCard.razor` | Displays a university in the results list |

| `UniversityDetails.razor` | Displays details of the selected university |

| `StudentApplicationForm.razor` | Provides the reusable student application form |



\## Screenshots



\### Home Page



!\[Home Page](docs/screenshots/home.png)



\### University Explorer



Initial Explorer page:



!\[University Explorer](docs/screenshots/explorer-initial.png)



Country selection:



!\[Country Dropdown](docs/screenshots/country-dropdown.png)



Selected country information and universities:



!\[Country Details and Universities](docs/screenshots/country-details-universities.png)



University search:



!\[University Search](docs/screenshots/university-search.png)



Selected university details:



!\[University Details](docs/screenshots/university-details.png)



\### Student Applications



Applications retrieved from the API:



!\[Student Applications](docs/screenshots/student-application.png)



Editing an existing application:



!\[Edit Student Application](docs/screenshots/edit-application.png)



\### Create Student Application



Empty application form:



!\[Create Application](docs/screenshots/create-application-empty.png)



Completed application form:



!\[Completed Application](docs/screenshots/create-application-filled.png)



Form validation:



!\[Form Validation](docs/screenshots/form-validation.png)



\### Loading State



!\[Loading Applications](docs/screenshots/loading-application.png)



\## Running the Application



1\. Clone the repository:



&#x20;  ```bash

&#x20;  git clone https://github.com/tfsousa1/fsd1-ca2-university-explorer-76192.git

&#x20;  ```



2\. Open the project folder.



3\. Run the application:



&#x20;  ```bash

&#x20;  dotnet run --project ./UniversityExplorer/UniversityExplorer.csproj

&#x20;  ```



4\. Open the local URL displayed in the terminal.



\## Repository



GitHub repository:



https://github.com/tfsousa1/fsd1-ca2-university-explorer-76192

