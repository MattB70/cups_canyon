
singleton TSShapeConstructor(Tree_oak_bush_bDae)
{
   baseShape = "./tree_oak_bush_b.dae";
};

function Tree_oak_bush_bDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "128", "1", "0");
}
