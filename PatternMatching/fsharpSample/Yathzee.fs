namespace PatternMatching

module Yathzee =
    type Category = 
        |Ones
        |Twos
        |Threes
        |Fours
        |Fives
        |Sixes
        |Pair 
        |TwoPair 
        |ThreeOfAKind 
        |FourOfAKind 
        |SmallStraight 
        |LargeStraight 
        |FullHouse 
        |Yahtzee
        |Chance

    let values = [1; 2; 3; 4; 5; 6;]

    let collect minimumRepetitions dice =
        values 
        |> List.map (fun x -> (x, (dice |> List.filter (fun y -> y = x) |> List.length))) 
        |> List.filter ( fun (_,y) -> y >= minimumRepetitions)

    let calculatePair dice =
        let atLeastPairs = dice |> collect 2
        match atLeastPairs with
        | head::_ ->
            let value, _ = atLeastPairs |> List.reduce (fun max value -> 
                                                        if fst value > fst max 
                                                        then value
                                                        else max)
            value * 2
        | _ -> 0
    
    let calculateMultiple multiple dice =
        let multipleDice = dice |> collect multiple
        match multipleDice with 
        | (x, _)::[] -> x * multiple
        | _ -> 0

    let calculateTwoPair dice =
        let atLeastPairs = dice |> collect 2
        match atLeastPairs with
        | (x, _)::(y,_)::[] -> x * 2 + y * 2
        | _ ->   0

    let calculateThree dice =
        calculateMultiple 3 dice

    let calculateFour dice =
        calculateMultiple 4 dice

    let isAStraightOfType straight dice =
        dice |> List.sort |> List.zip straight |> List.forall (fun (v1,v2) -> v1 = v2)

    let calculateStraight straight value dice = 
        if dice |> isAStraightOfType straight
        then value
        else 0

    let calculateSmall dice =
        calculateStraight [1;2;3;4;5] 15 dice

    let calculateLarge dice =
        calculateStraight [2;3;4;5;6] 20 dice

    let calculateFull dice =
        let collected  = dice |> collect 2
        match collected with
        | (v1,y1) :: (v2,y2) ::[] when (y1, y2) = (2, 3) || (y1 ,y2) = (3, 2)-> (v1 * y1) + (v2 * y2)
        | _ -> 0

    let calculateYathzee dice =
        let collected = dice |> collect 5
        match collected with
        | head::[] -> 50
        | _ -> 0

    let calculateChance dice =
        dice |> List.sum

    let calculateSingles dieValue dice =
        dice |> List.filter (fun y -> y = dieValue) |> List.sum

    let calculateScore category d1 d2 d3 d4 d5 =
        let dice = [d1; d2; d3; d4; d5]
        match category with
        | Ones -> calculateSingles 1 dice
        | Twos -> calculateSingles 2 dice
        | Threes -> calculateSingles 3 dice
        | Fours -> calculateSingles 4 dice
        | Fives -> calculateSingles 5 dice
        | Sixes -> calculateSingles 6 dice
        | Pair -> calculatePair dice
        | TwoPair -> calculateTwoPair dice
        | ThreeOfAKind -> calculateThree dice
        | FourOfAKind -> calculateFour dice
        | SmallStraight -> calculateSmall dice
        | LargeStraight -> calculateLarge dice
        | FullHouse -> calculateFull dice
        | Yahtzee -> calculateYathzee dice
        | Chance -> calculateChance dice
