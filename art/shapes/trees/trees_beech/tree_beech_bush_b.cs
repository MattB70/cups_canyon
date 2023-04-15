
singleton TSShapeConstructor(Tree_beech_bush_bDae)
{
   baseShape = "./tree_beech_bush_b.dae";
};

function Tree_beech_bush_bDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "128", "1", "0");
}
