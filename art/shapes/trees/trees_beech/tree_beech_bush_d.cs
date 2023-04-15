
singleton TSShapeConstructor(Tree_beech_bush_dDae)
{
   baseShape = "./tree_beech_bush_d.dae";
};

function Tree_beech_bush_dDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "128", "1", "0");
}
