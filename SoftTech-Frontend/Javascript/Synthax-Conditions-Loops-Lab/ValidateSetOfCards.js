function isSetFirstSolution(cards){
    // The programmer holds no responsibility of health risks or repercussions, 
    // before during or after viewing the undermentioned code
    firstCard = cards[0];
    secondCard = cards[1];
    thirdCard = cards[2];

    if (firstCard.color == secondCard.color && firstCard.color == thirdCard.color){
        if (firstCard.number == secondCard.number && firstCard.number == thirdCard.number){
            if (firstCard.shade == secondCard.shade && firstCard.shade == thirdCard.shade){
                if (firstCard.shape == secondCard.shape && firstCard.shape == thirdCard.shape){
                    return true;
                }
                else if (firstCard.shape != secondCard.shape && firstCard.shape != thirdCard.shape && secondCard.shape != thirdCard.shape){
                    return true;
                }
            }
            else if (firstCard.shade != secondCard.shade && firstCard.shade != thirdCard.shade && secondCard.shade != thirdCard.shade){
                if (firstCard.shape == secondCard.shape && firstCard.shape == thirdCard.shape){
                    return true;
                }
                else if (firstCard.shape != secondCard.shape && firstCard.shape != thirdCard.shape && secondCard.shape != thirdCard.shape){
                    return true;
                }
            }
        }
        else if (firstCard.number != secondCard.number && firstCard.number != thirdCard.number && secondCard.number != thirdCard.number){
            if (firstCard.shade == secondCard.shade && firstCard.shade == thirdCard.shade){
                if (firstCard.shape == secondCard.shape && firstCard.shape == thirdCard.shape){
                    return true;
                }
                else if (firstCard.shape != secondCard.shape && firstCard.shape != thirdCard.shape && secondCard.shape != thirdCard.shape){
                    return true;
                }
            }
            else if (firstCard.shade != secondCard.shade && firstCard.shade != thirdCard.shade && secondCard.shade != thirdCard.shade){
                if (firstCard.shape != secondCard.shape && firstCard.shape != thirdCard.shape && secondCard.shape != thirdCard.shape){
                    return true;
                }
                else if (firstCard.shape != secondCard.shape && firstCard.shape != thirdCard.shape && secondCard.shape != thirdCard.shape){
                    return true;
                }
            }
        }
    }
    else if (firstCard.color != secondCard.color && firstCard.color != thirdCard.color && secondCard.color != thirdCard.color){
        if (firstCard.number == secondCard.number && firstCard.number == thirdCard.number){
            if (firstCard.shade == secondCard.shade && firstCard.shade == thirdCard.shade){
                if (firstCard.shape == secondCard.shape && firstCard.shape == thirdCard.shape){
                    return true;
                }
                else if (firstCard.shape != secondCard.shape && firstCard.shape != thirdCard.shape && secondCard.shape != thirdCard.shape){
                    return true;
                }
            }
            else if (firstCard.shade != secondCard.shade && firstCard.shade != thirdCard.shade && secondCard.shade != thirdCard.shade){
                if (firstCard.shape == secondCard.shape && firstCard.shape == thirdCard.shape){
                    return true;
                }
                else if (firstCard.shape != secondCard.shape && firstCard.shape != thirdCard.shape && secondCard.shape != thirdCard.shape){
                    return true;
                }
            }
        }
        else if (firstCard.number != secondCard.number && firstCard.number != thirdCard.number && secondCard.number != thirdCard.number){
            if (firstCard.shade == secondCard.shade && firstCard.shade == thirdCard.shade){
                if (firstCard.shape == secondCard.shape && firstCard.shape == thirdCard.shape){
                    return true;
                }
                else if (firstCard.shape != secondCard.shape && firstCard.shape != thirdCard.shape && secondCard.shape != thirdCard.shape){
                    return true;
                }
            }
            else if (firstCard.shade != secondCard.shade && firstCard.shade != thirdCard.shade && secondCard.shade != thirdCard.shade){
                if (firstCard.shape != secondCard.shape && firstCard.shape != thirdCard.shape && secondCard.shape != thirdCard.shape){
                    return true;
                }
                else if (firstCard.shape != secondCard.shape && firstCard.shape != thirdCard.shape && secondCard.shape != thirdCard.shape){
                    return true;
                }
            }
        }
    }
    return false;
}

function isSetSecondSolution(cards){
    let propertySets = [new Set(), new Set(), new Set(), new Set()];

    for (let i = 0; i < cards.length; i++) {
        let setCount = 0;
        for (let j in cards[i]){
            propertySets[setCount].add(cards[i][j]);
            setCount++;
        }
        
    }

    for (let i = 0; i < 4; i++){
        if (propertySets[i].size == 1 || propertySets[i].size == cards.length){
        }
        else{
            return false
        }
    }
    return true;
}



