# Adding the given facts as global variables below
$states = ['Al', 'Fl', 'Ga', 'Ms', 'Tn']
$colors = ['r', 'g', 'b']
$neighbors = {  'Al' => ['Ms', 'Ga', 'Tn', 'Fl'],
                'Ms' => ['Tn', 'Al'], 
                'Ga' => ['Tn', 'Al', 'Fl'],
                'Tn' => ['Ms', 'Al', 'Ga'], 
                'Fl' => ['Al', 'Ga']
}

def coloring(a, i, len)
    if(i < len)
        for j in 0..2 # j is one of the given 3 colors
            a[$states[i]] = $colors[j] # assigning color j to i-th state
            # done with i-th state and going to recursion for remaining states
            coloring(a, i+1, len) # this is a recursion
        end
    end

    if(i == len) # all states are already assigned colors
        if(hasNoConflict(a))
            puts a # this prints a valid map coloring
        end
    end
end
# colorAssgn is a sample hash reflecting color assignment e.g. {'Al' => 'r', 'Fl' => 'b', 'Ga' => 'r', 'Ms' => 'g', 'Tn' => 'r'}

def hasNoConflict(colorAssg) # you need to complete this function
    # Basically, check colorAssg has any conflict with $neighbors; 
    #if conflict, return false; else return true

    if colorAssg.size == 1
        return true
    end    
    
    colorAssg.each do |k, v|
        for state in $neighbors[k]
            if (colorAssg[state] && colorAssg[state] == v)
                return false
            end
        end
    end
    return true
end

# Starting an empty hash, which means no color assignment yet
colAssg = {}

# 0 means no state is yet colored; 5 means total 5 states to color
coloring(colAssg, 0, 5)