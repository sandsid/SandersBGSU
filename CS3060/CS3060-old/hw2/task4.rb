

=begin
    
The Tree class presented in the text book(Day2) chapter is interesting,
but it does not allow you to specify a new tree with a clean user 
interface. Update the constructor and all other methods to accomodate 
the creation of a tree using a Hash. The initializer should accept a 
nested structure of Hashes. You should be able to specify a tree as below.
To test your functionality, you should traverse this entire tree and 
print out the contents.

=end



ruby_tree = Tree.new({ 
    ’ggrandparent ’ => { 
        ’grandparent1 ’ =>
            { ’parent1 ’ => { ’child1 ’ => {}} , 
                ’parent2 ’ => { ’child2 ’ => {} , ’child3 ’ => {}} 
        } , 
        ’grandparent2 ’ => 
            { ’parent3 ’ => { ’child4 ’ => {}} , 
                ’parent4 ’ => { ’child5 ’ => {} , ’child6 ’ => {}} 
        }
    }
})

