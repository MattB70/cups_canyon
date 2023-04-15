
singleton TSShapeConstructor(Tree_oak_bush_aDae)
{
   baseShape = "./tree_oak_bush_a.dae";
};

function Tree_oak_bush_aDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "128", "1", "0");
}
