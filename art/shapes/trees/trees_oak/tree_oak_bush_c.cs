
singleton TSShapeConstructor(Tree_oak_bush_cDae)
{
   baseShape = "./tree_oak_bush_c.dae";
};

function Tree_oak_bush_cDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
