
singleton TSShapeConstructor(Tree_douglasfir_deadDae)
{
   baseShape = "./tree_douglasfir_dead.dae";
   loadLights = "0";
};

function Tree_douglasfir_deadDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
