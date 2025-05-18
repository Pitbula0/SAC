using Spectre.Console;

var countinue = true;
while (countinue)
{
    Console.Clear();
    var choice = AnsiConsole.Prompt(new SelectionPrompt<string>()
    .Title("[green]Choose the figure you want to calculate the area of:[/]:")
    .AddChoices("Triangle", "Square", "Rectangle", "Circle"));
    switch (choice)
    {
        case "Triangle": Triangle(); break;
        case "Square": Square(); break;
        case "Rectangle": Rectangle(); break;
        case "Circle": Circle(); break;
    }
    var loop = AnsiConsole.Prompt(new SelectionPrompt<string>()
        .Title("Do you want to [green]continue[/]?")
        .AddChoices("Yes", "No"));
    if (loop == "Yes")
    {
        countinue = true;
    }
    else
    {
        countinue = false;
        Console.Clear();
    }
}
Console.WriteLine("Thank you for using my program");
AnsiConsole.MarkupLine("If you have any questions, please contact me at [green]Github Repository[/]");
Thread.Sleep(1000);
Console.WriteLine("Press any key to exit...");  
Console.ReadKey();



static void Triangle()
{
    int sideA = AnsiConsole.Prompt(new TextPrompt<int>("Enter [green]number[/] more than [b]0[/]")
        .PromptStyle("green")
        .ValidationErrorMessage("[red]That`s is not a valid lenght")
        .Validate(sideA => sideA switch
        {
            <= 0 => ValidationResult.Error("[red]1 is min value[/]"),
            _ => ValidationResult.Success(),
        }));
    int sideB = AnsiConsole.Prompt(new TextPrompt<int>("Enter [green]number[/] more than [b]0[/]")
        .PromptStyle("green")
        .ValidationErrorMessage("[red]That`s is not a valid lenght")
        .Validate(sideB => sideB switch
        {
            <= 0 => ValidationResult.Error("[red]1 is min value[/]"),
            _ => ValidationResult.Success(),
        }));
    int sideC = AnsiConsole.Prompt(new TextPrompt<int>("Enter [green]number[/] more than [b]0[/]")
        .PromptStyle("green")
        .ValidationErrorMessage("[red]That`s is not a valid lenght")
        .Validate(sideC => sideC switch
        {
            <= 0 => ValidationResult.Error("[red]1 is min value[/]"),
            _ => ValidationResult.Success(),
        }));
    double perimeter = sideA + sideB + sideC;
    double s = perimeter / 2;
    double area= Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
    double height = (area * 2) / sideA;
    var panelContent = new Rows(
        new Text($"Side A: {sideA}"),
        new Text($"Side B: {sideB}"),
        new Text($"Side C: {sideC}"),
        new Text($"Height: {height:0}"),
        new Text($"Perimeter: {perimeter:00}"),
        new Text($"Area: {area:00}")
    );
    var panel = new Panel(panelContent).Header("Triangle Information", Justify.Center)
        .Border(BoxBorder.Rounded)
        .Padding(1, 1, 1, 1);
    AnsiConsole.Write(panel);   
}

static void Square()
{
    int side = AnsiConsole.Prompt(new TextPrompt<int>("Enter [green]number[/] more than [b]0[/]")
    .PromptStyle("green")
    .ValidationErrorMessage("[red]That`s is not a valid lenght")
    .Validate(side => side switch
    {
        <= 0 => ValidationResult.Error("[red]1 is min value[/]"),
        _ => ValidationResult.Success(),
    }));
    double area = Math.Pow(side, 2);
    double perimeter = 4 * side;
    double diagonal = Math.Sqrt(Math.Pow(side, 2) + Math.Pow(side, 2));

    var panelContent = new Rows(
    new Text($"Side: {side}"),
    new Text($"Diagonal: {diagonal:0}"),
    new Text($"Perimeter: {perimeter:00}"),
    new Text($"Area: {area:00}")
);
    var panel = new Panel(panelContent).Header("Square Information", Justify.Center)
        .Border(BoxBorder.Rounded)
        .Padding(1, 1, 1, 1);
    AnsiConsole.Write(panel);
}
static void Rectangle()
{
    int sideA = AnsiConsole.Prompt(new TextPrompt<int>("Enter [green]number[/] more than [b]0[/]")
        .PromptStyle("green")
        .ValidationErrorMessage("[red]That`s is not a valid lenght")
        .Validate(sideA => sideA switch
        {
            <= 0 => ValidationResult.Error("[red]1 is min value[/]"),
            _ => ValidationResult.Success(),
        }));
    int sideB = AnsiConsole.Prompt(new TextPrompt<int>("Enter [green]number[/] more than [b]0[/]")
        .PromptStyle("green")
        .ValidationErrorMessage("[red]That`s is not a valid lenght")
        .Validate(sideB => sideB switch
        {
            <= 0 => ValidationResult.Error("[red]1 is min value[/]"),
            _ => ValidationResult.Success(),
        }));
    double area = sideA*sideB;
    double perimeter = 2*(sideA+sideB);
    double diagonal = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

    var panelContent = new Rows(
    new Text($"Side A: {sideA}"),
    new Text($"Side B: {sideB}"),
    new Text($"Diagonal: {diagonal:0}"),
    new Text($"Perimeter: {perimeter:00}"),
    new Text($"Area: {area:00}")
);
    var panel = new Panel(panelContent).Header("Rectangle Information", Justify.Center)
        .Border(BoxBorder.Rounded)
        .Padding(1, 1, 1, 1);
    AnsiConsole.Write(panel);
}
static void Circle()
{
    int radius = AnsiConsole.Prompt(new TextPrompt<int>("Enter [green]number[/] more than [b]0[/]")
    .PromptStyle("green")
    .ValidationErrorMessage("[red]That`s is not a valid lenght")
    .Validate(radius=> radius switch
    {
        <= 0 => ValidationResult.Error("[red]1 is min value[/]"),
        _ => ValidationResult.Success(),
    }));
    double area = Math.PI * Math.Pow(radius, 2);
    double perimeter = 2 * Math.PI * radius;
    double diameter = 2 * radius;
    var panelContent = new Rows(
        new Text($"Radius: {radius}"),
        new Text($"Diameter: {diameter:0}"),
        new Text($"Perimeter: {perimeter:00}"),
        new Text($"Area: {area:00}")
        );
    var panel = new Panel(panelContent).Header("Circle Information", Justify.Center)
        .Border(BoxBorder.Rounded)
        .Padding(1, 1, 1, 1);
    AnsiConsole.Write(panel);
}

