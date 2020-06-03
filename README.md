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
	Composition is when a class holds a reference to another class as a field. Inheritance is when one class is derived from another class to inherite all its instance variables 
	and methods. It may also add new variables and methods as well as override original methods from its parent with, providing it its own implementation. 
	
	Inheritance:
	public class A{}
	
	public class B : A {}
	
	Composition: 
	public class C{}
	public class D{
	
		private C {get; set;}
	}
	
2. **[10 marks]**  
	Polymorphism is often said to be a key component of Object-Oriented Programming. 
	Using examples from `C#` and `Java` illustrate how this concept is manifested.
	
	Answer: Polymorphism is used to describe variables which may refer at run-time to objects of different classes.
	
	Polymorphism examples are either method overloading (static) and method overriding (dynamic).
	
	Eg of former in java: 
	
		public class A{
	
		public  int methodA(int a, int b){
			return a + b;
		}
	
		public int methodA(int a){
			return -a;
		}
	}
	
	
	
	Eg of latter in c#
	
	public class A{
	
		public virtual string methodA(){
			return "methodA in A";
		}
	}
	
	public class B : A {
	
		public override string methodA(){
			return "methodA in B";
		}
	}
	
 
	
3. **[8 marks]**  
	Which design pattern(s) is used in the code fragment shown in the file `Complex.cs`?  
	You should clearly justify your answer.
	
	Answer:
	The interpreter patter, which provides a wasy to evaluate a language grammar or expression given a formalisation of the rules of that grammer/expression sructure and a way to interpret them.
	This is the case as in this example a sturct is provided foreach symbol (terminal or nonterminal) in the language and the signiture of the methods that interpret them are declared in an interface. The interpretation logic is 
	then implemented, in a composit-pattern fashion, in the struct implementing that interface.
		
4. **[15 marks]**  
  + Briefly describe how you would refactor a given class into one that embodies the singleton design pattern.  
	
	Answer: 
	I would declare a private static object attribute in the class of the class' type, declare the  constructor private and have a static method that when called, would check if that static object
	if it's null and if not just return it; else it would instanciate that static object using the private constructor and return it after. In addition I would add additinal security
	to protect agains breaking the singleton, by means of cloning, reflection or serialization .
	
  + Which design pattern would you use to assign more functionality to an object without sub-classing it?  
	Provide a detailed example to support your answer.
	
	Answer: 
	I would use the decorator pattern. The idea is that as well as having simple components that subclass an abstract class let’s say named, Component, we also have Decorators which also 
	subclass Component and take a component upon construction which gets stored in the decorator, so that any additional functionalities are declared within the Decorators who in turn
	execute the operations on the component they have stored. Notice, that these components can either be simple components, or wrapped components themselves, that is, decorators which 
	contain other decorators or simple components; so that every time we want to add an additional functionality, all we need is declare another Decorator that has a method/s with the 
	same signature as method/s declared in the Component abstract class, that desired additional functionality and then wrap the object which we desire to exhibit this functionality, into this
	decorator so that the operations declared in the decorator are invoked on the wrapper, giving the illusion that the object itself supports that operation, and so recursively until the first simple object is finally unwrapped.

	eg: 
	
	public abstract class Component{
	
		public abstract void Operation(); 
	}
	
	public class SimpleComponent : Component{
		public override void  Operation(){...}
	}
	
	public  abstract class Decorator : Component{
	
	private Component component {get; set}

	 public  Decorator(Component component){
		
		this.component= component;
	}
	
	public void Operation{
	
	if(component!= null)
		component.Operation(); 
		
	
	}
	}
	
	public class ConcreteDecorator(){
	
	public ConcreteDecorator(Component component) : base(component){}
		
		public void MyOperation() {
		 //possibility for doing some additional functionality here
			base.Operation();
		 //possibility for doing some additional functionality here
		}
	}
	
	main(){
	
	SimpleComponent sc = new SimpleComponent(); 
	ConcreteDecorator cdLevel1 = new ConcreteDecorator(sc); 
	ConcreteDecorator cdLevel2 = new ConcreteDecorator(cdLevel2); 
	cdLevel2.Operation(); //Calls 3 different Operation methods all with the name Operation, reversibly, unwrapping the objects.
	
	}
	
	
	
  + When would you use the Composite design pattern?  
 	Provide an appropriate example to illustrate your answer.  
	
	I would use the composite pattern in a case where the same operations are applicable to both an individual object and a wrapper that holds/contains/represents a number of the former but when invoked on
	a wrapper object, it would query its sub objects recursively, until we reach the root where no more unwarapping can be doen and then return the results of all the sub-queries, including its own, to up the tree to its first caller.
	As an example: 
	
	A tree, in particular a palm tree, has a method, count number of leaves (leaves being the actual twigs)
	Each twig has a method, count the number of leaves (leaves being the frond )
	Each frond has a method, count the number of leaves (leaves being the frond's own leaves)
	If we desired an operation that tells out the eventual number of frond leaves, it would then be wise, for the sake of this operation, not to treat being given a tree differently 
	then being given a twig or an individual frond. In this case, we could have an interface that declares a method count leaves, which all 3 implement and the client, needn't know 
	whether the object it is given is a simple component or a complex component since the objects themselves will have the count operation implemented differently depending on which of the
	two they are; so that in effect, the client, when given a tree or a or a twig, invoking the count operation will query first its sub components for how many leaves they have and then multiplies them by how many they themselves have whereas when given a frond
	on its own it  will just give the client straight away the number of its leaves knowing that it doesn't hold any further sub components. And so on for a collection of trees etc.

	
 	Provide a different example which shows when __not to use__ the pattern where a naïve developer might consider applying it.  
	
	I would not use it when the client needs to be aware of what is a simple object and what is a wrapper object.

	Eg: if we have a box of products and each product be a box of the same thing, or an individual root item, and the operation we need is find out the price, but if the item is above
	wrapper item, a surcharge is needed, and we need to know every time whether the item is such, then we've not achieved anything by implementing the composite pattern and here I would
	not use it.

	
	 
 	
5. **[10 marks]**  
	You are required to design an application for an advertisement company, which produces different types of publications; for example, books, articles, leaflets. 
	The company publishes their products in many media formats such as printed material, CD, DVD, online websites, etc. 
	How would you model the company products hierarchy (Publications, Media)?
	Provide an appropriate explanation to support your answer.

	I would use the abstract factory pattern in which the publications resemble the products , each concrete one implementing its abstract product interface and the media resembling the factories, each of them
	implementing the abstract factory interface. Eg. An Online websites factory has the methods, CreateBook(), CreateArticle(), CreateLeaflet() and so does the DVD factory has.
	Similarly, the interface Product can be implemented by various types of products, eg a book or an article, and because of the different factories, also of different variants (i.e. media).
	
	

5. **[8 marks]**  
	Which design pattern is implemented by the code within the `Example.cs` file?
	
	It is an implementation of the strategy pattern which says that if you have a class that does something specific, in our case travelling, in many different ways, you extract all of these algorithms
	in separate classess called strategies, in our case the different modes of travel, and rename the original class to context, in our case Transportation, 
	that has a field for storing one of the strategies, working with all strategies (only) through the same generic interface, and delegating the work to a linked strategy instead of executing it on its own. 
 	
	
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
	Because else, what's the purpose of this method, the caller could just call the Read() method directly? Therefore perhaps the that ReadTemperature() is used to check if the connection between Read and the physical
	sensor is broken whilst in Read(), throwing an exception would mean that we don't always get back a number value and we want to keep the two concerns, reading input and checing its validity, separate.
	
	+ Why would it be preferable to return an `Option` rather than throwing an exception?
	
	 So that it always returns the same type of value regardless of whether the connection is out of order as the methods calling it
	may not be aware of the possibility that it throws an exception. Also, this way we a method calling it need not necessarily be bothered with the meaning of the  values it returns so long as it returns the same type
	every time it's called.

	
	+ Write a method `Monitor` which monitors the temperature. The method has two arguments, `low` and `high`.


        ```
        public void Monitor(double low, double high) 
        {
        	// ...
        }
		```
		
		The method `Monitor` should read the temperature every second, and write out a warning (to the standard output) if the temperature is below `low`, or above `high`.
		If there is no response from the sensor for one minute the sensor the `Monitor` method should write a special warning to standard output.
