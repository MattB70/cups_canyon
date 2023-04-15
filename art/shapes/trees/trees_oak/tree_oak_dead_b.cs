
singleton TSShapeConstructor(Tree_oak_dead_bDae)
{
   baseShape = "./tree_oak_dead_b.dae";
};

function Tree_oak_dead_bDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
