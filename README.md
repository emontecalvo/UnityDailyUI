# DAILY UI in Unity

![Alt text](./day014img.png?raw=true "Day 014 - Countdown Timer")

### About
The Daily UI challenge can be found at http://www.dailyui.co/

Originally I started the Daily UI project using only Sketch and limited myself to a 15-minute timebox.

About 3/4 of the way through creating 15-minute designs in Sketch (some I loved, some not so much), I wanted to make these interactable.  Looking for a way to practice my C# and Unity skills, this seemed like a good challenge and with 100 UI's, the project will be a substantial UI library.

### Setup
If this project is something you would like to see on your local machine as it currently stands, please install Unity:
https://unity3d.com/unity

To play through the "days" using the previous/next buttons, you need to de-activate whichever DAILYUI (DAILYUI002 or DAILYUI014, etc) is currently highlighted in the Envelope hierarchy, and in the DailyUIManager ensure that "Daily UI Manager" C# script is active / checked.

### Development Roadmap

 - [] Continue to do at least one Daily UI in Unity per weekday until Day 100 is reached
 	- [x] Days 1-10
 	- [x] Days 11-20
 	- [] Days 21-30
 	- [] Days 31-40
 	- [] Days 41-50
 	- [] Days 51-60
 	- [] Days 61-70
 	- [] Days 71-80
 	- [] Days 81-90
 	- [] Days 91-100
 - [] Continue to refactor the code as patterns emerge
 - [] Re-design the previous/next buttons
 - [] Once Day 100 is completed, deploy to the Android store
 - [] Deploy live to the web


 #### Hierarchy / Layout

```
.

├── Main Camera
├── EventSystem
├── Canvas
	├── DailyUIManager  		Controller for scrolling through the DailyUI's
	│	├── Envelope  				Main Container for the DailyUI's
	│		├── DailyUI001			"Sign-up"
	│		├── DailyUI002			"Checkout"
	│		├── DailyUI003			"Landing Page"
	│		├── DailyUI004			"Calculator"
	│		├── DailyUI005			"App Icon"
	│		├── DailyUI006			"User Profile"
	│		├── DailyUI007			"Settings"
	│		├── DailyUI008			"404 page"
	│		├── DailyUI009			"Music Player"
	│		├── DailyUI010			"Social Share"
	│		├── DailyUI011			"Flash Error-Success"
	│		├── DailyUI012			"Shopping"
	│		├── DailyUI013			"Direct Messaging"
	│		├── DailyUI014			"Countdown Timer"
	│		├── DailyUI015			"On/Off Switch"
	│		├── DailyUI016			"Pop-up"
	│		├── DailyUI017			"Email-Receipt"
	│		├── DailyUI018			"Analytics"
	│		├── DailyUI019			"Leaderboard"
	│		├── DailyUI020			"Location Tracker"
	│		├── DailyUI021			"Home Monitor"....etc...
	│	|── GameObject      

```


 *Thanks for reading!*
 
 ~ Emily

  P.S.  Feel free to also checkout my DailyUI project built with ReactJS:
 * Github repo:  https://github.com/emontecalvo/ReactDailyUI
 * Live site:  coming soon
