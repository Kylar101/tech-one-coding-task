# Dollars To Words

## Building instructions

1. Clone project onto a computer with .NET 8 and Node 20 installed
2. Load solution into Visual Studio. (This project was implemented in Visual Studio 2022)
3. Run project using the `Start` button in Visual Studio
4. This should start up both the API and web page.
5. In the event that it doesn't, the web interface is served at `https://localhost:5173/` and the api definition is served at `http://localhost:5260/swagger/index.html`

## Approach Selected

### UI

#### Component Library

I selected Material UI as the component library as it is quick and simple to set up and start development. It is also well supported and maintained, and is well used through out the industry. It is also the Component library I use in my current role at Flight Centre. 

I also considered using Mantine as the component library, as it is also well supported and maintained, however, it requires extra setup than Material UI.

#### Forms

I selected React Hook Form as the form wrapper for similar reasons as Material UI. It is well supported and maintained, and is the library I use in my current role.

If I had selected Mantine as the component library, I would have used the form library that is included. I also considered Formik, but the form controls aren't as simple to setup and use.

#### State Management

I chose Jotai as the state management library. It is a simple and lightweight library that has very little overhead. 

I also considered Zustand and Redux. Zustand is also quite simple to use, however, when I have used it in the past there have been some issues with scale. Redux came to mind due to recent work projects, but I quickly discarded this option as it is quite a big library with a large amount of setup and would be overkill for this project.

#### Orchestration

In truly client facing projects, I would have separated out some variable, such as the apiClient baseURLs, into a `.env` file to allow it to be easly configured when deploying to a live environment. But in this case, I skipped this step to allow the users to view/run my program without needing to change/setup their config.

### API

#### Algorithm

I decided that the simplest way to convert a number to the string equivelant was to break the initial number in to blocks of up to three numbers. This allowed me to loop through the blocks and add the separators (thousands, millions, etc.) using the same function for each block and upping the separator from a counter. I experimented with several other methods of looping througth the blocks, but this method was the simplest option. 

Numbers one through twenty are handled coded through a `BelowTwenty` lookup as they are handled differently in the English language compared to larger numbers.