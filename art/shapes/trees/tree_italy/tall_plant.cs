
singleton TSShapeConstructor(Tall_plantDae)
{
   baseShape = "./tall_plant.dae";
};

function Tall_plantDae::onLoad(%this)
{
   %this.addImposter("25", "8", "0", "0", "128", "1", "0");
}
