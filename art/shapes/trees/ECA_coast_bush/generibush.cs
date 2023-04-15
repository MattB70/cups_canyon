
singleton TSShapeConstructor(GeneribushDae)
{
   baseShape = "./generibush.dae";
};

function GeneribushDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
