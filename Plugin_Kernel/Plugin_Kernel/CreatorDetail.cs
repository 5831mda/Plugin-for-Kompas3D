using System;
using Kompas6API5;
using Kompas6Constants3D;

namespace Plugin_Kernel
{
    public class CreatorDetail
    {

       public KompasObject _kompas;
       
        public CreatorDetail(KompasObject kompas)
        {
            this._kompas = kompas;
        }

        /// <summary>
        /// построение нижнего целиндра детали
        /// </summary>
        /// <param name="param"></param>
        public void DownCircle(Parameters param)
        {
           
            double Radios1 = param.Radios1;
            double Lenght1 = param.Lenght1;
            var document = (ksDocument3D)_kompas.Document3D();
            document.Create();
            var doc = (ksDocument3D)_kompas.ActiveDocument3D();
                ksPart part = (ksPart)doc.GetPart((short)Part_Type.pTop_Part);
                if (part != null)
                {
                    ksEntity entitySketch = (ksEntity)part.NewEntity((short)Obj3dType.o3d_sketch);
                    if (entitySketch != null)
                    {
                        ksSketchDefinition sketchDef = (ksSketchDefinition)entitySketch.GetDefinition();
                        if (sketchDef != null)
                        {
                            ksEntity basePlane = (ksEntity)part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
                            sketchDef.SetPlane(basePlane);
                            entitySketch.Create();

                            ksDocument2D sketchEdit = (ksDocument2D)sketchDef.BeginEdit();
                            sketchEdit.ksCircle(0, 0, Radios1, 1);
                            sketchDef.EndEdit();

                            ksEntity entityExtr = (ksEntity)part.NewEntity((short)Obj3dType.o3d_baseExtrusion);
                            if (entityExtr != null)
                            {
                                ksBaseExtrusionDefinition extrusionDef = (ksBaseExtrusionDefinition)entityExtr.GetDefinition();
                                if (extrusionDef != null)
                                {
                                    extrusionDef.directionType = (short)Direction_Type.dtNormal;
                                    extrusionDef.SetSideParam(true, (short)End_Type.etBlind, Lenght1, 0, false);
                                    extrusionDef.SetSketch(entitySketch);   // эскиз операции выдавливания
                                    entityExtr.Create();                    // создать операцию
                                }
                            }
                        }
                    }
                }
            }
        
        /// <summary>
        /// построение среднего цилиндра детали
        /// </summary>
        /// <param name="param"></param>
        public void MiddleCircle(Parameters param)
        {
            double Radios1 = param.Radios1;
            double Lenght1 = param.Lenght1;
            double Angle2 = param.Angle2;
            var doc = (ksDocument3D)_kompas.ActiveDocument3D();
            ksPart part1 = (ksPart)doc.GetPart((short)Part_Type.pTop_Part); // новый компонент
            if (part1 != null)
            {
                ksEntity entityOffsetPlane1 = (ksEntity)part1.NewEntity((short)Obj3dType.o3d_planeOffset);
                ksEntity entitySketch1 = (ksEntity)part1.NewEntity((short)Obj3dType.o3d_sketch);
                if (entityOffsetPlane1 != null)
                {
                    // интерфейс свойств смещенной плоскости
                    ksPlaneOffsetDefinition offsetDef1 = (ksPlaneOffsetDefinition)entityOffsetPlane1.GetDefinition();
                    if (offsetDef1 != null)
                    {
                        offsetDef1.offset = Lenght1;                          // расстояние от базовой плоскости
                        ksEntity basePlane1 = (ksEntity)part1.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
                        basePlane1.name = "Смещенная плоскость";         // название для плоскости

                        offsetDef1.SetPlane(basePlane1);                  // базовая плоскость
                        entityOffsetPlane1.name = "Смещенная плоскость"; // имя для смещенной плоскости
                        entityOffsetPlane1.hidden = true;
                        entityOffsetPlane1.Create();                     // создать смещенную плоскость

                        if (entitySketch1 != null)
                        {
                            ksSketchDefinition sketchDef1 = (ksSketchDefinition)entitySketch1.GetDefinition();
                            if (sketchDef1 != null)
                            {
                                sketchDef1.SetPlane(entityOffsetPlane1);  // установим плоскость XOY базовой для эскиза
                                entitySketch1.Create();                 // создадим эскиз

                                // интерфейс редактора эскиза
                                ksDocument2D sketchEdit1 = (ksDocument2D)sketchDef1.BeginEdit();
                                sketchEdit1.ksCircle(0, 0, Radios1, 1);
                                sketchDef1.EndEdit();                    // завершение редактирования эскиза
                                ksEntity entityExtr1 = (ksEntity)part1.NewEntity((short)Obj3dType.o3d_baseExtrusion);
                                if (entityExtr1 != null)
                                {
                                    ksBaseExtrusionDefinition extrusionDef1 = (ksBaseExtrusionDefinition)entityExtr1.GetDefinition();
                                    if (extrusionDef1 != null)
                                    {
                                        extrusionDef1.directionType = (short)Direction_Type.dtNormal;
                                        extrusionDef1.SetSideParam(true, (short)End_Type.etBlind, 5, Angle2, true);
                                        extrusionDef1.SetSketch(entitySketch1);   // эскиз операции выдавливания
                                        entityExtr1.Create();                    // создать операцию
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// построение верхней части цилиндра
        /// </summary>
        /// <param name="param"></param>
        public void UpCircle(Parameters param)
        {
            double Radios2 = param.Radios2;
            double Lenght1 = param.Lenght1;
            double Lenght2 = param.Lenght2;
            var doc = (ksDocument3D)_kompas.ActiveDocument3D();
            ksPart part2 = (ksPart)doc.GetPart((short)Part_Type.pTop_Part); // новый компонент
            if (part2 != null)
            {
                ksEntity entityOffsetPlane2 = (ksEntity)part2.NewEntity((short)Obj3dType.o3d_planeOffset);
                ksEntity entitySketch2 = (ksEntity)part2.NewEntity((short)Obj3dType.o3d_sketch);
                if (entityOffsetPlane2 != null)
                {
                    ksPlaneOffsetDefinition offsetDef2 = (ksPlaneOffsetDefinition)entityOffsetPlane2.GetDefinition();
                    if (offsetDef2 != null)
                    {
                        offsetDef2.offset = Lenght1 + 5;                          // расстояние от базовой плоскости
                        ksEntity basePlane2 = (ksEntity)part2.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
                        basePlane2.name = "Смещенная плоскость";         // название для плоскости

                        offsetDef2.SetPlane(basePlane2);                  // базовая плоскость
                        entityOffsetPlane2.name = "Смещенная плоскость"; // имя для смещенной плоскости
                        entityOffsetPlane2.hidden = true;
                        entityOffsetPlane2.Create();                     // создать смещенную плоскость

                        if (entitySketch2 != null)
                        {
                            ksSketchDefinition sketchDef2 = (ksSketchDefinition)entitySketch2.GetDefinition();
                            if (sketchDef2 != null)
                            {
                                sketchDef2.SetPlane(entityOffsetPlane2);  // установим плоскость XOY базовой для эскиза
                                entitySketch2.Create();                 // создадим эскиз

                                ksDocument2D sketchEdit2 = (ksDocument2D)sketchDef2.BeginEdit();
                                sketchEdit2.ksCircle(0, 0, Radios2, 1);
                                sketchDef2.EndEdit();                    // завершение редактирования эскиза
                                ksEntity entityExtr2 = (ksEntity)part2.NewEntity((short)Obj3dType.o3d_baseExtrusion);
                                if (entityExtr2 != null)
                                {
                                    ksBaseExtrusionDefinition extrusionDef2 = (ksBaseExtrusionDefinition)entityExtr2.GetDefinition();
                                    if (extrusionDef2 != null)
                                    {
                                        extrusionDef2.directionType = (short)Direction_Type.dtNormal;
                                        extrusionDef2.SetSideParam(true, (short)End_Type.etBlind, Lenght2, 0, false);
                                        extrusionDef2.SetSketch(entitySketch2);   // эскиз операции выдавливания
                                        entityExtr2.Create();                    // создать операцию
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// создание фаски
        /// </summary>
        /// <param name="param"></param>
        public void CreateChamfer(Parameters param)
        {
            double Lenght1 = param.Lenght1;
            double Lenght2 = param.Lenght2;
            double Angle1 = param.Angle1;
            var doc = (ksDocument3D)_kompas.ActiveDocument3D();
            ksPart part2 = (ksPart)doc.GetPart((short)Part_Type.pTop_Part); // новый компонент
            if (part2 != null)
            {
                ksEntityCollection collect2 = (ksEntityCollection)part2.EntityCollection((short)Obj3dType.o3d_face);
                if (collect2 != null && collect2.SelectByPoint(0, 0, Lenght1 + 5 + Lenght2) && collect2.GetCount() != 0)
                {
                    ksEntity entityChamfer = (ksEntity)part2.NewEntity((short)Obj3dType.o3d_chamfer);
                    if (entityChamfer != null)
                    {
                        ksChamferDefinition ChamferDef = (ksChamferDefinition)entityChamfer.GetDefinition();
                        if (ChamferDef != null)
                        {
                            ChamferDef.tangent = false;
                            ChamferDef.SetChamferParam(true, Angle1, Angle1);
                            ksEntityCollection arr = (ksEntityCollection)ChamferDef.array();    // динамический массив объектов
                            if (arr != null)
                            {
                                for (int i = 0, count = collect2.GetCount(); i < count; i++)
                                    arr.Add(collect2.GetByIndex(i));
                                entityChamfer.Create();
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// вырез в нижней части цилиндра
        /// </summary>
        /// <param name="param"></param>
        public void FlatPart(Parameters param)
        {
            double Radios1 = param.Radios1;
            double Cut1 = param.Cut1;
            double Cut2 = param.Cut2;
            var doc = (ksDocument3D)_kompas.ActiveDocument3D();
            ksPart part3 = (ksPart)doc.GetPart((short)Part_Type.pTop_Part);  // новый компонент
            if (part3 != null)
            {
                ksEntity entitySketch3 = (ksEntity)part3.NewEntity((short)Obj3dType.o3d_sketch);
                if (entitySketch3 != null)
                {
                    ksSketchDefinition sketchDef3 = (ksSketchDefinition)entitySketch3.GetDefinition();
                    if (sketchDef3 != null)
                    {
                        ksEntity basePlane = (ksEntity)part3.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
                        sketchDef3.SetPlane(basePlane); // установим плоскость
                        sketchDef3.angle = 0;
                        entitySketch3.Create();         // создадим эскиз

                        ksDocument2D sketchEdit3 = (ksDocument2D)sketchDef3.BeginEdit();
                        sketchEdit3.ksLineSeg(Radios1, Radios1, -Radios1, Radios1, 1);
                        sketchEdit3.ksLineSeg(Radios1, Cut1, -Radios1, Cut1, 1);
                        sketchEdit3.ksLineSeg(Radios1, Cut1, Radios1, Radios1, 1);
                        sketchEdit3.ksLineSeg(-Radios1, Cut1, -Radios1, Radios1, 1);
                        sketchDef3.EndEdit();   // завершение редактирования эскиза

                        ksEntity entityCutExtr = (ksEntity)part3.NewEntity((short)Obj3dType.o3d_cutExtrusion);
                        if (entityCutExtr != null)
                        {
                            ksCutExtrusionDefinition cutExtrDef = (ksCutExtrusionDefinition)entityCutExtr.GetDefinition();
                            if (cutExtrDef != null)
                            {
                                cutExtrDef.SetSketch(entitySketch3);    // установим эскиз операции
                                cutExtrDef.directionType = (short)Direction_Type.dtReverse; //прямое направление
                                cutExtrDef.SetSideParam(false, (short)End_Type.etBlind, Cut2, 0, true);
                                cutExtrDef.SetThinParam(false, 0, 0, 0);
                            }
                            entityCutExtr.Create(); // создадим операцию вырезание выдавливанием
                        }
                    }
                }
            }
            ksPart part4 = (ksPart)doc.GetPart((short)Part_Type.pTop_Part);  // новый компонент
            if (part4 != null)
            {
                ksEntity entitySketch4 = (ksEntity)part4.NewEntity((short)Obj3dType.o3d_sketch);
                if (entitySketch4 != null)
                {
                    ksSketchDefinition sketchDef4 = (ksSketchDefinition)entitySketch4.GetDefinition();
                    if (sketchDef4 != null)
                    {
                        ksEntity basePlane = (ksEntity)part4.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
                        sketchDef4.SetPlane(basePlane); // установим плоскость
                        sketchDef4.angle = 0;
                        entitySketch4.Create();         // создадим эскиз

                        ksDocument2D sketchEdit4 = (ksDocument2D)sketchDef4.BeginEdit();
                        // введем новый эскиз - квадрат
                        sketchEdit4.ksLineSeg(-Radios1, -Radios1, Radios1, -Radios1, 1);
                        sketchEdit4.ksLineSeg(-Radios1, -Cut1, Radios1, -Cut1, 1);
                        sketchEdit4.ksLineSeg(-Radios1, -Cut1, -Radios1, -Radios1, 1);
                        sketchEdit4.ksLineSeg(Radios1, -Cut1, Radios1, -Radios1, 1);
                        sketchDef4.EndEdit();   // завершение редактирования эскиза

                        ksEntity entityCutExtr2 = (ksEntity)part4.NewEntity((short)Obj3dType.o3d_cutExtrusion);
                        if (entityCutExtr2 != null)
                        {
                            ksCutExtrusionDefinition cutExtrDef2 = (ksCutExtrusionDefinition)entityCutExtr2.GetDefinition();
                            if (cutExtrDef2 != null)
                            {
                                cutExtrDef2.SetSketch(entitySketch4);    // установим эскиз операции
                                cutExtrDef2.directionType = (short)Direction_Type.dtReverse; //прямое направление
                                cutExtrDef2.SetSideParam(false, (short)End_Type.etBlind, Cut2, 0, true);
                                cutExtrDef2.SetThinParam(false, 0, 0, 0);
                            }

                            entityCutExtr2.Create(); // создадим операцию вырезание выдавливанием
                        }
                    }
                }
            }
        }
    }
}


