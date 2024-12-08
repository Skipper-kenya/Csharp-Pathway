//LINQ => Language integrated querry


List<int> scores = [1,45,23,52,67,99,75,38,10,15]; 

var scores2 = new List<int> {1,45,23,52,67,99,75,38,10,15};

IEnumerable<int> scoresQuerry = 
    from score in scores
    where score > 50
    orderby score descending
    select score;

foreach(var i in scoresQuerry){
    Console.WriteLine(i);
};



//approach 2: using method syntax 

IEnumerable<int> scoresQuerry2 = scores.Where(s => s > 50).OrderByDescending(s=>s);

foreach(var i in scoresQuerry2){
    Console.WriteLine(i);
};