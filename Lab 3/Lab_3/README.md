# Lab 3 - CRUD, Serialization

### Variant 6 - Magazine storage/manager

### Magazine
Has collection of Articles, Title and Periodicity properties

### Article
Has Author, Title, number of pages and Fee properties

### Author
Has First and Last names and Date of Birth

### Periodicity
Is the enum of Weekly, Monthly and Quarterly

## Data model
![Data model](https://i.imgur.com/lM7Wa0d.png)

## Architecture
The whole app is built using MVVM architecture. ViewModels never directly reference any concrete Views, altough some contain methods that call `Close()` method on `Window` object.

Models don't know about ViewModels, let alone Views, as well as Views don't know about Models.
![Architecture mode](https://i.imgur.com/pOgcdQk.png)
