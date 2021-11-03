# BackendApiChallenge
Take home challenge

THIS PROJECT REQURES NEWTONSOFT.JSON TO RUN!!!
To install this in Visual Studio, Go to Tools -> NuGet Package Manager -> Manage Nuget Packages for Solution... 
 - Then Search for newtonsoft.json in the browser tab and install!
If you prefer to use the .NET CLI, simply open up a command prompt in the solution through visual studio and type:
"dotnet add package Newtonsoft.Json" (without the quotation symbols).
 
To run this API project with Docker from Visual Studio, select 'Docker' in the Build dropdown selection, and click the Green 'Play' button, or hit F5. 
This will build the solution and start the Docker container. If you're going through the command prompt, navigate to the project folder and enter the following two commands:
"docker build -t aspnetapp ." (without quotation symbols)
"docker run -d -p 8080:80 --name myapp BackendApiChallenge" (without quotation symbols)
Then visit localhost:8080 to see the app in the web browser.
 
If you would like to build and run this project without Docker, simply select IIS Express, or BackendApiChallenge from the dropdown, and click the Green 'Play Button, or
hit F5!
 
To test the POST feature of this project, I utilized Postman. You may also utilize Postman to see the GET request, however a browser should launch upon building and running
this project that will display the contents of the GET request.
 
Please contact me immediately and let me know if you have any issues or questions!
tblaney97@comcast.net
