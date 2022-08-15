using CSharp.ProblemSolving.Tasks.TaskNo2.Delegates;

Document doc = new Document();

PostBlog blogPoster = new PostBlog();

// instantiate delegate from document
var blogDelegate = new Document.SendDoc(blogPoster.DeliverPost);
doc.DocumentSender(blogDelegate);

// or pass it directly
doc.DocumentSender(blogPoster.DeliverPost);

EmailSender emailSender = new EmailSender();
var emailDelegate = new Document.SendDoc(emailSender.SendEmail);
doc.DocumentSender(emailDelegate);
doc.DocumentSender(emailSender.SendEmail);


