
class Tree
    attr_accessor :children, :node_name
    def initialize(hash)
        @children = Array.new
        hash.each_key  {|node| @node_name = node}
        hash[@node_name].each {|key , value| @children.push(Tree.new({key=>value})) if value != nil}
    end 
    def visit_all(&block)    
        visit &block  
        children.each {|c| c.visit_all &block} 
    end 
    def visit(&block)     
        block.call self 
    end

end

ruby_tree = Tree.new({ 
    'ggrandparent' => { 
        'grandparent1' =>
            { 'parent1'  => { 'child1' => {}} , 
              'parent2'  => { 'child2' => {} , 'child3' => {}} 
        } , 
        'grandparent2' => 
            { 'parent3' => { 'child4' => {}} , 
              'parent4' => { 'child5' => {} , 'child6' => {}} 
        }
    }
})

count = 1
ruby_tree.visit_all do |node|
    puts node.node_name if node.node_name
    node.children.each{|child| 
        puts "#{child.node_name}" 
        count +=1
    }
end


puts "Total nodes:\t #{count}"