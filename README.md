# Singleton Pattern in C#

## Purpose
The Singleton design pattern is a crucial architectural choice in software development. Its primary purpose is to ensure that a class has only one instance, providing a global point of access throughout the application's lifecycle. This helps maintain consistency and prevents unexpected issues.

## Repository Overview
This repository showcases the implementation of the Singleton pattern in a C# console application, featuring two distinct case scenarios.

### ConfigurationManager Singleton
The `ConfigurationManager` class is crafted to retrieve configurations using the Singleton pattern. It guarantees the creation of a single instance, protected by locks for thread safety. This ensures that only one instance of the `ConfigurationManager` is accessible, preventing inconsistencies in configuration data.

### VoteMachine Singleton
In the case of the `VoteMachine` class, the Singleton pattern is applied to count votes by incrementing the vote count each time the instance is accessed. This prevents multiple instances from causing discrepancies in the vote count, ensuring a reliable and consistent result.

## Usage
To integrate the Singleton pattern into your C# application, follow these steps:

1. **Include Singleton Class:** Import the Singleton class into your project.
2. **Instantiate Singleton:** Create and access a single instance of a class using the Singleton pattern.
