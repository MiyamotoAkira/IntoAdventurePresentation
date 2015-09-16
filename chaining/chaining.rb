class ThreeDObject
  def initialize(x, y, z)
    @x = x
    @y = y
    @z = z
  end
      
  def translate(x, y, z)
    # we translate the object
    self
  end

  def rotate(x, y, z)
    # we rotate the object
    self
  end

  def scale(x, y, z)
    # we scale the object
    self
  end
  
end

player = ThreeDObject.new(5,4,3)
player.scale(1,1,1).translate(1,0,0).rotate(90,0,0)
