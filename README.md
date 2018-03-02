```                                                                      
#             .___      __     _____          __                         __  .__               
#    ______ __| _/_____/  |_  /  _  \  __ ___/  |_  ____   _____ _____ _/  |_|__| ____   ____  
#   /  ___// __ |/ __ \   __\/  /_\  \|  |  \   __\/  _ \ /     \\__  \\   __\  |/  _ \ /    \ 
#   \___ \/ /_/ \  ___/|  | /    |    \  |  /|  | (  <_> )  Y Y  \/ __ \|  | |  (  <_> )   |  \
#  /____  >____ |\___  >__| \____|__  /____/ |__|  \____/|__|_|  (____  /__| |__|\____/|___|  /
#       \/     \/    \/             \/                         \/     \/                    \/ 
```

# seleniumCSharp#
Selenium Startup Project for C# .NET


Introduction
------------
This project is made for anyone who is looking for a starting point for writing functional tests using Selenium WebDriver and C#.

This projet was written using Microsoft Visual Studio 2015 Community.   


Project Packages
-----
* Sdet.Auto.PageObjects:  
Contains class files for each web page being tested.  Page element definitions / mappings, and functions for interacting with page elements.

* Sdet.Auto.TestHelper:  
    - ConfigSettings: contains helper functions for reading App.config.  
    - IoLibrary: contains helper functions used across tests.  
    - LoggingLibrary: contains custom functions for comparing actual to expected conditions.  
    - TestAssert: Is a custom assert, used to track if a verification point has failed.  The class variable is latched, once set to false it will remain false for the remainder of the test run. 
    - WebDriverExtensions: Contains helper function to instantiate WebDriver to the appropriate browser type.  In the future, WebDriverExensions class will contain helper functions to handle driver waits for page elements conditions. 


Visual Studio Project
-----
This project is written in C# and tests can be executed invoking mstest.exe via command line or Test Explorer via Visual Studio IDE. 


Page Object Model
-----
Page object model is used in this framework.  Each web page will have its own java.class and within each class contains page element mappings and functions / methods used to interact /verify a specific web page under test.  


Test web page
-----
    http://the-internet.herokuapp.com/    
        
Continuous Integration(CI)
------------
A web hook has been setup with AppHarbor for all Push and Pull Requests.
 
 
Selenium WebDriver
------------
This project is configured to use Firefox & Chrome WebDriver's.  The default is set to Chrome.  The WebDriver's added to this project will only work on Windows.  


Selenium Grid
------------
Tests in this solution can also run on the Selenium Grid.  Selenium Grid is hosted by www.gridlastic.com.

Questions / Contact / Contribute
------------
Feel free to fork this repo, add to it, and create a pull request if you like to contribute.  

If you have any questions, you can contact me via email: `sdet.testautomation@gmail.com`
