
singleton TSShapeConstructor(Tree_beech_forest_aDae)
{
   baseShape = "./tree_beech_forest_a.dae";
};

function Tree_beech_forest_aDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
