
singleton TSShapeConstructor(Tree_beech_bush_eDae)
{
   baseShape = "./tree_beech_bush_e.dae";
};

function Tree_beech_bush_eDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "128", "1", "0");
}
