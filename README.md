# 🌱 Tree Pea

This is a demo project which aims to showcase the cross-platform features of C# and Xamarin forms.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

For development, the latest version of Visual Studio is required. The latest version can be downloaded from [here](https://visualstudio.microsoft.com/downloads/).

<!--A step by step series of examples that tell you how to get a development env running-->
### Installing

1. Clone the repo
```sh
git clone https:://github.com/PaulLoots/WorkHeart.git
```
2. Open the project

Use `Open Workspace` in Visual Studio.


## Unit Tests

These are the unit tests that can be run on this system

### GetLevelFromXpTest

This test checks if the correct level is selected based on the Xp level. Navigate to Test Explorer and run unit tests.

```
//ARRANGE
int xp = 1500;
int expectedLevel = 1;

//ACT
var result = Level.GetLevelFromXp(xp);


//ASSERT
Assert.AreEqual(expectedLevel, result);
```

<!-- USAGE EXAMPLES -->
## Features

### Selecting Tracking Items

![image1](image1)

## Built With

* [Xamarin Forms](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/)

## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## Authors

* **Armand Pretorius** - *Front End & Unit Testing* - [PaulLoots](https://github.com/PaulLoots)
* **Paul Loots** - *Code Behind* - [ArmandPretorius](https://github.com/ArmandPretorius)

See also the list of [contributors](https://github.com/your/project/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Hat tip to anyone whose code was used
* Inspiration
* etc
