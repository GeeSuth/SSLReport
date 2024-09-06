# SSL Certificate Checker

## Overview

The **SSL Certificate Checker** is a simple yet powerful tool built in C# to retrieve SSL certificate information for a specified domain. It checks the expiration date and fetches the Subject Alternative Names (SAN) for the domain. The tool is designed to help developers and system administrators monitor and manage SSL certificates for their websites, ensuring security and compliance with best practices.

## Features

- **SSL Expiration Date**: Retrieve the SSL certificate expiration date for any domain.
- **Subject Alternative Names (SAN)**: List all SAN entries, ensuring you have complete visibility of domain aliases and subdomains covered by the SSL certificate.
- **No Caching**: Ensures that the tool fetches the live certificate, avoiding any cached results, giving you real-time data.
- **Domain Validation**: A regex check ensures that the input is in the proper format (e.g., `example.com`), making it easy to validate domains before querying.

## Benefits

This tool was created to solve a common issue faced by web developers and IT teams—ensuring that SSL certificates are always up-to-date and provide secure coverage for all required domains and subdomains.

By automating the retrieval of SSL certificate information, this tool:
- **Prevents Expired Certificates**: By monitoring the expiration date, you can avoid downtime caused by expired certificates.
- **Improves Security**: It ensures your website or service is using the latest SSL certificate and is protected from potential vulnerabilities.
- **Saves Time**: Automates a tedious, manual process so you can focus on more important tasks.
- **Enables Visibility**: Easily track and list all alternative domains (SANs) to ensure proper coverage without manual inspection.
- **Export Json**: can export the result in json
- **Auto Save**: the app will always remember your result

## Usage

### Requirements

- .NET Core SDK or .NET Framework
- Internet connection (for querying live SSL certificates)

### How to Use

1. Clone the repository:
    ```bash
    git clone https://github.com/GeeSuth/SSLReport.git
    ```
2. Open the project in your favorite C# IDE (e.g., Visual Studio, Rider, or Visual Studio Code).
3. Run the project to fetch and display the SSL certificate details, including:
   - Expiration date
   - Subject Alternative Names (SAN)

Example output:

![image](https://github.com/user-attachments/assets/2e344d35-9c63-42de-bc97-9137672ba4ed)


![image](https://github.com/user-attachments/assets/976e8f20-4518-490e-ab74-1caf9663d973)

![image](https://github.com/user-attachments/assets/28e17c3a-97d1-463b-a700-18740d3a25fc)

