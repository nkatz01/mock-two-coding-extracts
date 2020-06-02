# Mock Test Two

## BIRKBECK (University of London)

## Software Design and Programming - COIY062H7
## Software and Programming III - BUCI056H6

### Duration - three hours

1. Candidates should attempt **ALL** questions on the paper.
2. The number of marks varies from question to question.
3. You are advised to look through the entire examination paper before getting started to plan your strategy.
4. Simplicity and clarity of expression in your answers is important.
5. You may answer questions using only the `C#` programming language.
6. You should avoid the use of mutable state or mutable collections in your solutions whenever possible.
7. You should use the solution and project files that are provided. 
	Each "text" solution can be provided in a plain text or pdf file within the appropriate project folder.

--

1. **[6 marks]**  
	Describe the difference between composition and inheritance, and provide appropriate examples of each.
	
2. **[10 marks]**  
	Polymorphism is often said to be a key component of Object-Oriented Programming. 
	Using examples from `C#` and `Java` illustrate how this concept is manifested.
	
3. **[8 marks]**  
	Which design pattern(s) is used in the code fragment shown in the file `Complex.cs`?  
	You should clearly justify your answer.
		
4. **[15 marks]**  
  + Briefly describe how you would refactor a given class into one that embodies the singleton design pattern.  
  + Which design pattern would you use to assign more functionality to an object without sub-classing it?  
	Provide a detailed example to support your answer.
  + When would you use the Composite design pattern?  
 	Provide an appropriate example to illustrate your answer.  
 	Provide a different example which shows when __not to use__ the pattern where a naïve developer might consider applying it.  
 	
5. **[10 marks]**  
	You are required to design an application for an advertisement company, which produces different types of publications; for example, books, articles, leaflets. 
	The company publishes their products in many media formats such as printed material, CD, DVD, online websites, etc. 
	How would you model the company products hierarchy (Publications, Media)?
	
	Provide an appropriate explanation to support your answer.

5. **[8 marks]**  
	Which design pattern is implemented by the code within the `Example.cs` file?
	
5. **[18 marks]**  
	Create a single dimension array containing some string objects. 
	Sort this vector by: 
	+ length (i.e., shortest to longest),
	+ reverse length (i.e., longest to shortest),
	+ first character, and
	+ strings that contain the character `"` first, everything else second.
	
	You should use the functional programming features of C# to answer this question using LINQ.
	
5. **[25 marks]**  
	The fictitious company *ShiverOrSweat* develops temperature sensors for buildings. 
	They have to develop a class which can be used for reading the temperature. 
	You have just been hired by this company, and you are now to design part of this class, `Sensor`.
	
	A method `Read` has already been written which returns a double indicating the temperature reading in celsius.
	
	```
	public double Read() 
	{
		//...
	}
	```
	
	If the connection to the physical sensor is "out of order" `Read` returns `-300`, although this happens quite rarely.
	+ Implement a method `ReadTemperature` which calls the `Read` method. You should throw an exception when the `Read` method returns a value of `-300`.
	
		```
    	public double ReadTemperature()
    	{
    		// ...
		}
		```	
	+ For this example, why is it preferable to throw an exception as against returning the value `-300` which the calling method could check?  
	+ Why would it be preferable to return an `Option` rather than throwing an exception?
	+ Write a method `Monitor` which monitors the temperature. The method has two arguments, `low` and `high`.


        ```
        public void Monitor(double low, double high) 
        {
        	// ...
        }
		```
		
		The method `Monitor` should read the temperature every second, and write out a warning (to the standard output) if the temperature is below `low`, or above `high`.
		If there is no response from the sensor for one minute the sensor the `Monitor` method should write a special warning to standard output.
