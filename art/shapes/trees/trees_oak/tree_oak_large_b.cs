
singleton TSShapeConstructor(Tree_oak_large_bDae)
{
   baseShape = "./tree_oak_large_b.dae";
};

function Tree_oak_large_bDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "1", "256", "1", "0");
}
