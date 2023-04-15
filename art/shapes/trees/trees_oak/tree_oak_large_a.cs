
singleton TSShapeConstructor(Tree_oak_large_aDae)
{
   baseShape = "./tree_oak_large_a.dae";
};

function Tree_oak_large_aDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
