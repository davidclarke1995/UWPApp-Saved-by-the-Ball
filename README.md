# Saved by the Ball

## Brief

The UWP application should be well designed with a clear purpose in mind. Answer the question
“why will the user open this app for a second time?” as part of the design process. What makes your
app better than the others available offering the same function?
The application can be a game (UNITY is acceptable with C# scripting) or an interactive information
app. What the app does is up to you. You can have a single page app, or one with many pages – that
is a choice. 

## Requirements

- Well-designed UI that is fit for purpose and provides a good user experience.
- Uses local/roaming storage for storing data and/or settings that are necessary for or
enhance this user experience.
- Demonstrates appropriate use of the sensors/hardware available on UWP capable devices, 
Accelerometer, gyroscope, location services, sound, network service (connect to
server for data), camera, multi touch gestures
- The app must be more than a simple information app. It must have interactivity as part of
the design.

## Project idea

For this project, I wanted to design an app based for fans of Premier League football. It would be something that users could look at the best teams in the league and add their own flair to by adding in players from other leagues themselves or by creating whole new players and adding them into their favourite teams. The user could put themselves into their favourite team if they were to choose. This would all be stored in a local database. Also in the database would be a rating system/favourite system that the user could select different players and add them to favourites and see them under the favourites window.
  I want the app to open with a nice menu bar at the side that can bring you to different options such as "Home" and "Settings". Within the "Home" page the user can see the different football teams available in the tabs. I want the user to have be able to see a couple of teams that they can read information on (All teams to be added as the app grows). There will be a link to the official website of each team and there will be a an option to see where the stadium is on the map.
  
 ## How to run
 
 - Copy my git repository and perform a git clone in the cmd command prompt.
 - Open the project solution through Visual Studio from the folder.
 - Right click on the project and select "Deploy".
 - Select the green arrow that says "Device" beside it to run the project and it should start.
  
 ## Project Functionality
 
 When the app opens, a Splash page is displayed to show the user what this app is about. An image of a football in a field. Once that closes down, the user will see a menu on the left hand side. This has 4 options, Settings, About, Trailer and Store. "About" brings the user to a page that tells them a little about what the app is designed for aided with a humerous gif of Alan Pardrew dancing. "Trailer" opens a page which plays a media element. A video of the Premier League season. "Store" is a hyperlink that sends the user to a football store where they can bye t-shirts, jerseys, boots and lots more. "Settings" never got completed unfortunately. When the user is in the home page, they have a pivot displaying 3 Premier League teams. In time, I will add as many teams as I can, going through each team in the PM and eventually moving onto La Liga and the Bundesliga. Once the user selects the team of their choice, they can select the "View" button which brings them to their chosen team. With each click of the buttons, there is a progression sound that plays. There is also a seperate sound for opening the menu in the home page. Each page has with it a "Back" button which takes the user a page back and plays a "going down" sound. In the team pages, the user can look at some of the stats and facts of the club. They can select the club crest which brings them directly to the club official website. They can select the button at the bottom "View xxxx on the map" and it will bring the user to a seperate window with a geolocation of the team stadium. It is centered to the exact co-ordinates, zoomed in and pin pointed with a flag aided with a picture of that stadium.
 
 ## Features that I wanted
 
 Before Visual Studio crashed, I had been working extensively on a local database using SQLite. The idea was that each team page would have clickable tiles with pictures of players faces from that team. The user could click into a tile and read stats. The stats I had were: Name, age, shirt number and rating out of 100. With more time and in the future, I can add more statistics to this and feature more players. There is an empty tile also that when the user selects, they can input their own player. This can be anyone from a real footballer to the user themself. From here they can alter the stats as much as they would like. I had it working as much as it would read in a file and output what the user has written. I was unable to regenerate new tiles after one had been made. 
 
 Another feature that I was working on but never got to include in my project was a different rating system. I was able to have clickable stars that would be golden when selected and greyed out depending on the rating given. The rating in number would also be shown beside the stars. This is as far as I got but with more time and less disruption, I would have loved to have a "Favourites" tab on the menu and use a local storage that the user can give a rating to a player and favourite them and the player (along with their info) would save into the favourites page.
 
  
 ## Features of the project
 
 - PivotItem showing the different teams that the user can scroll though
 - Tabs selecting which pivots
 - MediaElement for images and for videos
 - SplitView for the bar on the left hand side, Ive decided I want it open for desktop users to begin with, and closed for tablet users and hidden for phone users
 - SplitViewDisplayMode is what alters the layout of the main page when you switch between desktop, tablet and phone views. 
 - await asynchronization
 - Navigate move between page to page
 - Frame needed to actually create new frames to make new windows to switch between, this new window can be shut down without killing the running program
 - ScrollViewer adds a scroll bar to the page
 - ElementSoundPlayer sound effects when navigating throughout the pages
  And many other features

## Problems that occurred
These are some of the frustrating encounters I had whilst working on this expansive project. Some issues may have taken hours or days to solve or I might not have even gotten an answer but wanted to include for suggestions and tips as to how to go about a similar project  in the future.

### Developer Options
My first problem was not being able to turn on developer options for windows 10, ie not being able to run the code.
There was little to no information on the web for this solution as most peoples queries online prompted a response from a user to just find the developers options on the settings and quickly switch it to developer mode. Unfortunately my options were greyed out. I did find someones response useful eventually. I had to open PowerShell for windows with administrator privileges and enter the following lines of code:
 - reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\AppModelUnlock" /t REG_DWORD /f /v "AllowDevelopmentWithoutDevLicense" /d "1"
- reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\AppModelUnlock" /t REG_DWORD /f /v "AllowAllTrustedApps" /d "1"
 This in turn, solved my issue after many days of struggling to figure out the problem.  
 
 Reference: https://forums.windowscentral.com/developers-corner/367530-developer-options-greyed-out.html

### Media not workinng
I was unable to show any images in separate pages at all and the same was for videos. I knew there was a problem with the <MediaElement> but I did know what it was. All the pictures that would not work for me would work if I ran them through the MainPage so I knew the issue was not the path. After a few days of struggling, I decided to pose the question on the forum StackOverflow.com and someone responded the following day with advice to change my source to "ms-appx:///Images/Video.mp4"
Once I applied this, it worked perfectly. Ive included my question in the reference
  
Reference: https://stackoverflow.com/questions/49764870/mediaelement-not-playing-video?noredirect=1#comment86565627_49764870

### No MainPage Background Image
One problem that occurred was the fact that I could not seem to have a background image on my main page. I had one that I really wanted to use but unfortunately I believe that the combination of having both a splitview panel  and pivot meant that I could not have an image seen also. I tried tirelessly for hours over a few days but could not find anything to support having an image over a panel. I thought I had figured it out by using blur and Background=”Transparent” within a few grids and splitview etc but it never worked.

Reference: https://social.msdn.microsoft.com/Forums/windowsapps/en-US/e7b5fd17-3465-4a94-81af-5c056c992c11/add-image-to-pivot-title?forum=wpdevelop

### Splash Page
One feature that I wanted for the app was the inclusion of a splash page and this took me a long time to figure out as I was unsure why Visual Studio was not allowing to add an image in to create a Splash image. Eventually I discovered that it would only accept a certain scale and pixels but had to be exact and after a long time of searching, I still could not find anything that would fit. I decided to download photoshop and alter an image myself. I had to resize it to the correct amount of pixels and then crop it to keep the aspect ratio. Eventually my image was accepted but it uses the pathway of my C drive and does not allow me to change. Therefore I doubt it will be seen or graded on.

## Udemy

When I started this project, I found it very difficult to find content online or even on StackOverflow to aid me in writing my own app so I decided to pay for an online Udemy course. This was just over 13 hours in total going through the different compinents in what makes up an application. It was not as good as I thought it would be as there was still a lot of figuring out to do myself in terms of how to piece things together that I had learned. Also the narrator doing the course was using Visual Studio 2014 while I was using the 2017 version. I thought mine would just be better and more up-to-date but the differences were copious. This was a course that was probably aimed at a much more accomplished programmer and not someone who had been using C# for only a couple of months. None the less, I completed the 13 hours and received my certificate which I have linked in my Repository.  

## References

I am proud that I did not need many places to reference. I did not copy and paste any large amounts of code from anywhere online. I watched videos from my Udemy course but wrote everything down myself and manipulated it to work the way I wanted. There is no code in my project that I am unsure of what it does. The only time I used StackOverflow was when I had a problem that I could not solve on my own. When finding the issue, I would learn and understand why it was an issue with my code and then fix it. This can be seen in my question that I posed myself on StackOverflow which is referenced under the "Problems that occurred" heading.

- https://www.udemy.com/complete-uwp-course/learn/v4/content
- https://stackoverflow.com/questions


## Additional Comments
Throughout doing this project, I found myself being very frustrated as I spent more time trying to figure out issues with Visual Studio than actually writing code. I spent hours on end trying to figure out why my project would not deploy or run. I lost count the amount of times I had to uninstall and reinstall or Repair Visual Studio. I also worked for many days on a seperate project that held many pages with code that I had yet to implement into my app but was very valuable to me including a rating system for players and most importantly the local database. But with Visual Studio being the most temperamental program I have ever used, it crashed, deleting that entire project. After the crash I lost many images and parts from the app project also so I spent a lot of time repairing and mending what I had already completed. During the final week of our time we had left to finish the project, another problem had arrisen. This was the final problem as I was no longer able to access Visual Studio again after, leaving me no choice but to just submit what I had left. A message kept appearring prompting me to Install an emulator. I installed it 5 or 6 times but the message would not go away (screenshot of message provided). With all these problems, of course I never got a chance to complete the app and request for it to be put on the store. I wanted to add this as I have spent longer on this project than I have ever spent on a project before and I feel like the many hours used on this has taken away from other projects but I am believe that I am very knowledgable about UWP but havent been able to show my true strength in it.

Aside from this, I had many problems with GitHub also (I can only blame myself). When I tried committing to GitHub at one point, it told me that there was a file that exceeded the 100 mb limit. It was referring to a video file. I decided to delete this file and re-commit. It produced the same error, time and time again. I tried finding a solution over the internet but no problem seemed to relate. After eventually speaking to a member of the GitHub support team, I learned that even though I had deleted the video, I could not perform a git push as the video commit was still in my branch history. We exchanged emails about how to fix this problem but we could not come to a resolution. Eventually I resorted to creating a new repository and copying all my project files into a new folder and committing those. It finally pushed to GitHub.

Finally I'd like to add that I am proud that throughout all the many unusual hurdles, I've still come out with a working functioning UWP application that I have written myself 100% and would be happy to take any questions you have about my project.
