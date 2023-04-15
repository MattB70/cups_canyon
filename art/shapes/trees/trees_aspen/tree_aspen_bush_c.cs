
singleton TSShapeConstructor(Tree_aspen_bush_cDae)
{
   baseShape = "./tree_aspen_bush_c.dae";
};

function Tree_aspen_bush_cDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "128", "1", "0");
}
