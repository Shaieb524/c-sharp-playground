using CSharp.ProblemSolving.Tasks.TaskNo2.Abstraction.Interfaces;

Document doc1 = new Document();

// we cant create instance of an interface, but we can assign it to a var that imeplents that interface
Storable printableDoc = doc1;

// we can cast the var to a type to use methods from the type that implement the interface
Document doc2 = printableDoc as Document;
if (doc2 != null)
    Console.WriteLine(doc2.Status());


Console.WriteLine(printableDoc.Write());

