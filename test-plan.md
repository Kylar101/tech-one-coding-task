# Test Plan: **Dollars to Words Conversion Website**

## 1. **Objective**
The purpose of this test plan is to validate that the website accurately converts numbers into their corresponding words across various scenarios and input conditions. This ensures that the application functions as expected and meets the requirements.

## 2. **Scope**
The scope of testing includes functional testing, usability testing, performance testing, security testing, and compatibility testing of the website. The primary functionality being tested is the conversion of numeric input (integers and decimals) into their word equivalents.

## 3. **Test Approach**
- **Manual Testing** will be conducted for functional and usability tests.
- **Automated Testing** tools may be used for performance and load testing.
- **Cross-browser and device testing** will ensure the site functions on different platforms.

## 4. **Testing Types**

### 4.1 **Functional Testing**
1. **Valid Input:**
   - Verify if valid integer numbers (e.g., 0, 1, 10, 100, 9999) are correctly converted into words.
   - Verify decimal numbers (e.g., 0.5, 100.25, 9999.99) are correctly converted into words.
   - Verify negative numbers are correctly converted into words with the word "negative" added (e.g., -10 → "negative ten").
   - Verify large numbers (e.g., millions, billions) are converted accurately.

2. **Invalid Input:**
   - Verify the system handles non-numeric input (e.g., alphabets, special characters) with an appropriate error message.
   - Check if the website rejects incomplete or empty input.
   
3. **Boundary Testing:**
   - Test edge cases such as the smallest and largest acceptable numbers.
   - Test inputs at boundaries of language, such as zero and just under the maximum allowed number.

4. **Input Length:**
   - Verify the maximum allowed length for input numbers and ensure that inputs beyond this limit are handled properly.

5. **Language/Locale Support:**
   - Verify that the website can convert numbers to words in different languages/locales (if applicable).

### 4.2 **Usability Testing**
1. **User Interface:**
   - Ensure the input field is clearly labeled and accepts valid inputs.
   - Test if error messages are displayed in a user-friendly manner for invalid input.
   - Check that the converted words are displayed clearly and in an understandable format.
   
2. **Accessibility:**
   - Test the site for compatibility with screen readers and other assistive devices.
   - Ensure the input and output text are readable for people with visual impairments.

### 4.3 **Performance Testing**
1. **Response Time:**
   - Measure how fast the website converts numbers to words for different input sizes.

### 4.4 **Security Testing**
1. **Input Validation:**
   - Ensure that all input is sanitized to prevent potential injection attacks (e.g., SQL or XSS attacks).

### 4.5 **Compatibility Testing**
1. **Cross-Browser Testing:**
   - Test on different browsers (e.g., Chrome, Firefox, Safari, Edge) to ensure consistent functionality.
   
2. **Device Testing:**
   - Test on multiple device types (desktop, tablet, mobile) to ensure a responsive design and functionality.

## 5. **Test Environment**
- **Operating Systems**: Windows, macOS, Linux, iOS, Android
- **Browsers**: Chrome, Firefox, Edge, Safari
- **Devices**: Desktop, tablet, mobile

## 6. **Test Cases**

| **Test ID** | **Test Case** | **Test Steps** | **Expected Result** | **Actual Result** | **Pass/Fail** |
|-------------|---------------|----------------|---------------------|-------------------|---------------|
| TC001       | Convert valid integer | Enter a valid integer (e.g., 123) | "One hundred and twenty three dollars" | | |
| TC002       | Convert decimal number | Enter a decimal number (e.g., 123.45) | "One hundred and twenty three dollars and forty five cents" | | |
| TC003       | Handle non-numeric input | Enter alphabetic string (e.g., "abc") | Displays validation error | | |
| TC004       | Handle empty input | Leave input field blank | Displays validation error | | |
| TC005       | Convert large number | Enter a large number (e.g., 999999) | "Nine hundred and ninety nine thousand nine hundred and ninety nine dollars" | | |
| TC006       | Cross-browser testing | Open site on Chrome, Firefox, Safari | Site functions correctly | | |
| TC007       | Verify that 0 returns correctly | Enter 0 as number | "Zero Dollars" | | |
| TC008       | Verify that cents returns correctly | Enter 12.4 as number | "Twelve Dollars and Forty Cents" | | |

## 7. **Risks**
- Misinterpretation of decimal formats.
- Slow response times for very large numbers.
- Inconsistent results across different locales if multi-language support is provided.

## 8. **Deliverables**
- Test Plan Document
- Test Cases
- Bug Reports
- Test Summary Report

## 9. **Timeline**
Testing will occur over a two-week period with different phases for functional, performance, and usability testing.
